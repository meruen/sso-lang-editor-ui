using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace sso_lang_editor_ui {
    internal class Data {
        public SQLiteConnection connection;
        public const string DB_NAME = @".\data.db";

        public Data() {
            connect();
        }

        public void createDb() {
            SQLiteConnection.CreateFile(DB_NAME);
        }

        public void deleteDb() {
            if (connection.State == System.Data.ConnectionState.Open) {
                connection.Close();
            }

            if (File.Exists(DB_NAME)) {
                File.Delete(DB_NAME);
            }
        }

        public void connect() {
            try {
                string connectionString = @"Data Source=" + DB_NAME;
           
                connection = new SQLiteConnection(connectionString);
                connection.Open();
            } catch {
                MessageBox.Show("Could not connect to database.");
            }
        }

        public void disconnect() {
            if (connection.State == System.Data.ConnectionState.Open) {
                connection.Close();
            }
        }

        public void createTables(
            Lang lang, 
            fMain parent
        ) {
            parent.startProgress(lang.folders.Values.Sum(elements => elements.Count));
            

            parent.setStatusText("Creating new database");

            new SQLiteCommand("DROP TABLE IF EXISTS folders", connection).ExecuteNonQuery();
            new SQLiteCommand("CREATE TABLE folders ( id INTEGER, elements INTEGER, name VARCHAR(64) )", connection).ExecuteNonQuery();
            new SQLiteCommand("DROP TABLE IF EXISTS elements", connection).ExecuteNonQuery();
            new SQLiteCommand("CREATE TABLE elements ( id INTEGER, folder_id INTEGER, key VARCHAR(64), original VARCHAR(64), translated VARCHAR(64), FOREIGN KEY (folder_id) REFERENCES folder(id) )", connection).ExecuteNonQuery();
            new SQLiteCommand("DROP TABLE IF EXISTS configs", connection).ExecuteNonQuery();
            new SQLiteCommand("CREATE TABLE configs ( version INTEGER(2), timestamp INTEGER, folders_count INTEGER )", connection).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM configs", connection).ExecuteNonQuery();
            createConfig(lang);

            for (var folderIndex = 0; folderIndex < lang.foldersCount; folderIndex++) { 
                var folderName = lang.folderKeys[folderIndex];
                var folder = lang.folders[folderName];

                parent.setStatusText($"Indexing {folderName}");
                createFolder(folderIndex, folder.Count, folderName);

                var transaction = connection.BeginTransaction();

                for (var elementIndex = 0; elementIndex < folder.Count; elementIndex++) {
                    var element = folder[elementIndex];
                    var command = new SQLiteCommand("INSERT INTO elements VALUES (@id, @folder_id, @key, @original, @translated)", connection);

                    command.Parameters.AddWithValue("@id", elementIndex);
                    command.Parameters.AddWithValue("@folder_id", folderIndex);
                    command.Parameters.AddWithValue("@key", element.key);
                    command.Parameters.AddWithValue("@original", element.original);
                    command.Parameters.AddWithValue("@translated", element.translated);
                    command.ExecuteNonQuery();

                    parent.stepProgress();
                    Application.DoEvents();
                }

                transaction.Commit();
            }

            parent.setStatusText("");
            parent.clearProgress();
        }

        public void createConfig(Lang lang) {
            var command = new SQLiteCommand("INSERT INTO configs VALUES (@version, @timestamp, @foldersCount)", connection);
            command.Parameters.AddWithValue("@version", lang.version);
            command.Parameters.AddWithValue("@timestamp", lang.timestamp);
            command.Parameters.AddWithValue("@foldersCount", lang.foldersCount);
            command.ExecuteNonQuery();
        }

        public void createFolder(int folderIndex, int folderCount, string folderName) {
            var command = new SQLiteCommand("INSERT INTO folders VALUES (@folderIndex, @folderCount, @folderName)", connection);
            command.Parameters.AddWithValue("@folderIndex", folderIndex);
            command.Parameters.AddWithValue("@folderCount", folderCount);
            command.Parameters.AddWithValue("@folderName", folderName);
            command.ExecuteNonQuery();
        }
    }
}
