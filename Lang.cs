using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sso_lang_editor_ui {
    internal class Lang {
        public struct Element {
            public string key;
            public string original;
            public string translated;
        }

        public List<String> folderKeys;
        public Dictionary<String, List<Element>> folders;
        public string idString;
        public int version;
        public int timestamp;
        public int foldersCount;
        public fMain parent;
        private short startPoint;
        private short endPoint;

        public Lang(fMain parent) {
            this.parent = parent;
            folderKeys = new List<String>();
            folders = new Dictionary<String, List<Element>>();
        }

        public void clear() {
            folderKeys.Clear();
            folders.Clear();
            idString = "";
            version = 0;
            timestamp = 0;
            foldersCount = 0;
        }

        public void saveToFile(string path) {
            var fileStream = new FileStream(path, FileMode.Create);
            var writer = new BinaryWriter(fileStream);

            writer.Write(Encoding.UTF8.GetBytes("LANG"));

            writer.Write(version);
            writer.Write(timestamp);
            writer.Write(foldersCount);

            parent.startProgress(foldersCount);

            for (var folderIndex = 0; folderIndex < foldersCount; folderIndex++) {
                writer.Write((short)-17065); // Start Point

                var folderName = folderKeys[folderIndex];
                var folder = folders[folderName];
                var folderNameBytes = Encoding.UTF8.GetBytes(folderName);

                writer.Write(folderNameBytes.Length);
                writer.Write(folderNameBytes);
                writer.Write(folder.Count);

                parent.setStatusText($"Writing folder {folderName}");

                for (var elementIndex = 0; elementIndex < folder.Count; elementIndex++) {
                    var element = folder[elementIndex];

                    var keyBytes = Encoding.UTF8.GetBytes(element.key);
                    writer.Write(keyBytes.Length);
                    writer.Write(keyBytes);

                    var originalBytes = Encoding.UTF8.GetBytes(element.original);
                    writer.Write(originalBytes.Length);
                    writer.Write(originalBytes);

                    var translatedBytes = Encoding.UTF8.GetBytes(element.translated);
                    writer.Write(translatedBytes.Length);
                    writer.Write(translatedBytes);

                    Application.DoEvents();
                }

                writer.Write((short)-16915); // End Point
                parent.stepProgress(); 
            }

            fileStream.Close();
            parent.setStatusText($"done");
            parent.clearProgress();
        }

        public void loadFromDb(Data data) {
            clear();
            parent.clearProgress();

            var configCommand = new SQLiteCommand("SELECT * FROM configs", data.connection);
            var configReader = configCommand.ExecuteReader();
            configReader.Read();

            version = configReader.GetInt16(0);
            timestamp = configReader.GetInt32(1);
            foldersCount = configReader.GetInt32(2);

            parent.startProgress(foldersCount);

            var foldersCommand = new SQLiteCommand("SELECT * FROM folders ORDER BY ID", data.connection);
            var foldersReader = foldersCommand.ExecuteReader();

            while (foldersReader.Read()) {
                var folderName = foldersReader.GetString(2);
                folderKeys.Add(folderName);
                folders[folderName] = new List<Element>();
                
                parent.stepProgress();
                parent.setStatusText($"Reading folder {folderName} from DB");
                Application.DoEvents();
            }

            parent.clearProgress();

            var countCommand = new SQLiteCommand("SELECT COUNT(*) FROM elements", data.connection);
            var count = Convert.ToInt32(countCommand.ExecuteScalar());
            
            var chunkSize = 10000;
            var chunks = (int)Math.Ceiling(count / (double)chunkSize);

            parent.startProgress(chunks);

            for (var chunk = 0; chunk < chunks; chunk++) {
                var command = new SQLiteCommand("SELECT * FROM elements ORDER BY folder_id, id LIMIT @limit OFFSET @offset", data.connection);
                command.Parameters.AddWithValue("@limit", chunkSize);
                command.Parameters.AddWithValue("@offset", chunkSize * chunk);
                var reader = command.ExecuteReader();

                var originalIndex = reader.GetOrdinal("original");
                var translatedIndex = reader.GetOrdinal("translated");
                var folderIdIndex = reader.GetOrdinal("folder_id");
                var keyIndex = reader.GetOrdinal("key");

                while (reader.Read()) {
                    var original = reader.GetString(originalIndex);
                    var translated = reader.GetString(translatedIndex);
                    var folderId = reader.GetInt32(folderIdIndex);
                    var key = reader.GetString(keyIndex);
                    
                    var folderName = folderKeys[folderId];

                    var element = new Element();
                    element.original = original;
                    element.translated = translated;
                    element.key = key;

                    folders[folderName].Add(element);
                }

                parent.stepProgress();
                parent.setStatusText($"Preparing chunks to write: {chunk + 1}/{chunks}");
                Application.DoEvents();
            }

            parent.clearProgress();
            parent.setStatusText("");
        }

        public bool loadFromFile(String path) {
            FileStream fileStream;
            BinaryReader reader;

            try {
                fileStream = new FileStream(path, FileMode.Open);
                reader = new BinaryReader(fileStream);

                idString = new String(reader.ReadChars(4));

                if (idString != "LANG") {
                    MessageBox.Show("The header does not match with expected: byte[4] = 'LANG'");
                    return false;
                }

                version = reader.ReadInt32();
                timestamp = reader.ReadInt32();
                foldersCount = reader.ReadInt32();

                parent.startProgress(foldersCount);

                for (var folderIndex = 0; folderIndex < foldersCount; folderIndex++) {
                    startPoint = reader.ReadInt16();

                    var nameSize = reader.ReadInt32();
                    var folderName = new String(reader.ReadChars(nameSize));
                    var elementsCount = reader.ReadInt32();

                    parent.setStatusText($"Reading folder '{folderName}'");

                    folderKeys.Add(folderName);

                    for (var elementIndex = 0; elementIndex < elementsCount; elementIndex++) {
                        var element = new Element();

                        var keySize = reader.ReadInt32();
                        element.key = readString(reader, keySize);

                        var originalSize = reader.ReadInt32();
                        element.original = readString(reader, originalSize);

                        var translatedSize = reader.ReadInt32();
                        element.translated = readString(reader, translatedSize);

                        if (!folders.ContainsKey(folderName)) {
                            folders[folderName] = new List<Element>();
                        }

                        folders[folderName].Add(element);
                        Application.DoEvents();
                    }

                    parent.stepProgress();
                    endPoint = reader.ReadInt16();
                }

                parent.clearProgress();
                parent.setStatusText("");
                fileStream.Close();

                return true;
            } catch (Exception e) {
                MessageBox.Show($"The application failed to parse the file! Exception: {e.Message}");
                return false;
            }
        }

        public string readString(BinaryReader reader, int size) {
            var bytes = reader.ReadBytes(size);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
