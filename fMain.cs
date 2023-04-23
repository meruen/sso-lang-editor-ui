using System.Data.SqlClient;
using System.Data.SQLite;
using static sso_lang_editor_ui.Lang;

namespace sso_lang_editor_ui {
    public partial class fMain : Form {
        private Lang lang;
        private Data data;
        private int currentPage;
        private int totalPages;
        private string searchStr;

        public const int PAGE_LIMIT = 50;

        public fMain() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            currentPage = 0;
            totalPages = 0;
            searchStr = "";
            
            data = new Data();

            if (File.Exists(Data.DB_NAME)) {
                data.connect();
                loadFoldersFromDb();
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "SSO Lang Data (*.data)|*.data";

            if (openDialog.ShowDialog() == DialogResult.OK) {
                foldersList.Items.Clear();
                dataGrid.Rows.Clear();

                data.connect();

                lang = new Lang(this);

                currentPage = 0;
                totalPages = 0;
                updateTotalPages();
                disableNavigation();
                
                if (lang.loadFromFile(openDialog.FileName)) {
                    data.createTables(lang, this);
                    loadFoldersFromDb();
                }

                enableNavigation();
            }
        }

        private void btSave_Click(object sender, EventArgs e) {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "SSO Lang Data (*.data)|*.data";

            if (saveDialog.ShowDialog() == DialogResult.OK) {
                lang = new Lang(this);
                lang.loadFromDb(data);
                lang.saveToFile(saveDialog.FileName);
            }
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void foldersList_DoubleClick(object sender, EventArgs e) {
            currentPage = 0;

            loadElementsFromDb();
        }

        private void loadFoldersFromDb(Dictionary<int, int> indexedCounts = null) {
            try {
                var oldIndex = foldersList.SelectedIndex;
                var command = new SQLiteCommand("SELECT * FROM folders ORDER BY id", data.connection);
                var reader = command.ExecuteReader();

                foldersList.Items.Clear();
                foldersList.Items.Add("(ALL)");

                while (reader.Read()) {
                    var id = reader.GetInt32(0);
                    var elements = reader.GetInt32(1);
                    var name = reader.GetString(2);

                    if (indexedCounts != null) {
                        if (indexedCounts.ContainsKey(id)) {
                            elements = indexedCounts[id];
                        } else {
                            elements = 0;
                        }
                    }

                    foldersList.Items.Add($"{name} ({elements})");
                }

                if (oldIndex >= 0 && oldIndex < foldersList.Items.Count) {
                    foldersList.SelectedIndex = oldIndex;
                }
            } catch {

            }
        }

        private void loadElementsFromDb() {
            var selectedIndex = foldersList.SelectedIndex;
            if (selectedIndex == -1) {
                foldersList.SelectedIndex = 0;
                selectedIndex = 0;
            }

            disableNavigation();

            var selectedFolder = foldersList.SelectedItem.ToString();
            
            dataGrid.Rows.Clear();

            SQLiteCommand command;
            SQLiteCommand countAllCommand;

            countAllCommand = new SQLiteCommand("SELECT folder_id, COUNT(*) FROM elements WHERE 1=1", data.connection);

            if (selectedFolder == "(ALL)") {                
                command = new SQLiteCommand("SELECT * FROM elements WHERE 1=1", data.connection);
            } else {
                command = new SQLiteCommand("SELECT * FROM elements WHERE folder_id = @folderId", data.connection);
                command.Parameters.AddWithValue("@folderId", selectedIndex - 1);
            }

            if (searchStr.Length > 0) {
                command.CommandText += " AND LOWER(translated || original) LIKE '%' || @searchStr || '%'";
                countAllCommand.CommandText += " AND LOWER(translated || original) LIKE '%' || @searchStr || '%'";
                command.Parameters.AddWithValue("@searchStr", searchStr.ToLower());
                countAllCommand.Parameters.AddWithValue("@searchStr", searchStr.ToLower());
            }

            var indexedCounts = new Dictionary<int, int>();

            countAllCommand.CommandText += " GROUP BY folder_id";
            var countsReader = countAllCommand.ExecuteReader();
            
            while (countsReader.Read()) {
                var folderId = countsReader.GetInt32(0);
                var count = countsReader.GetInt32(1);
                indexedCounts[folderId] = count;
            }

            indexedCounts[-1] = indexedCounts.Values.Sum();

            var totalElements = 0;

            if (indexedCounts.ContainsKey(selectedIndex - 1)) {
                totalElements = indexedCounts[selectedIndex - 1];
            }

            loadFoldersFromDb(indexedCounts);

            totalPages = (int)Math.Ceiling((double)totalElements / PAGE_LIMIT);
            updateTotalPages();

            command.CommandText += " LIMIT @limit OFFSET @offset";
            command.Parameters.AddWithValue("@limit", PAGE_LIMIT);
            command.Parameters.AddWithValue("@offset", PAGE_LIMIT * currentPage);
            
            var reader = command.ExecuteReader();
            var elementIdIndex = reader.GetOrdinal("id");
            var originalIndex = reader.GetOrdinal("original");
            var translatedIndex = reader.GetOrdinal("translated");
            var folderIdIndex = reader.GetOrdinal("folder_id");

            while (reader.Read()) {
                var elementId = reader.GetInt32(elementIdIndex);
                var original = reader.GetString(originalIndex);
                var translated = reader.GetString(translatedIndex);
                var folderId = reader.GetInt32(folderIdIndex);

                dataGrid.Rows.Add(new String[] { 
                    @original,
                    @translated, 
                    elementId.ToString(),
                    folderId.ToString() 
                });
            }

            enableNavigation();
        }

        public void updateTotalPages() {
            textPage.Text = $"{(totalPages == 0 ? 0 : currentPage + 1)} / {totalPages}";
        }

        public void disableNavigation() {
            btNext.Enabled = false;
            btLast.Enabled = false;
            btPrev.Enabled = false;
            btFirst.Enabled = false;
            Application.DoEvents();
        }
        
        public void enableNavigation() {
            btNext.Enabled = currentPage < totalPages - 1;
            btLast.Enabled = btNext.Enabled;
            btPrev.Enabled = currentPage > 0;
            btFirst.Enabled = btPrev.Enabled;
            Application.DoEvents();
        }

        private void btPrev_Click(object sender, EventArgs e) {
            currentPage--;
            loadElementsFromDb();
        }

        private void btNext_Click(object sender, EventArgs e) {
            currentPage++;
            loadElementsFromDb();
        }

        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 1) {
                var translated = Convert.ToString(dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue);
                var newTranslated = Convert.ToString(dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                var idValue = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["idColumn"].Value);
                
                var folderId = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["folderIdColumn"].Value);

                if (newTranslated.Length > 0) {
                    var command = new SQLiteCommand("UPDATE elements SET translated = @translated WHERE id = @elementId AND folder_id = @folderId", data.connection);
                    command.Parameters.AddWithValue("@translated", newTranslated);
                    command.Parameters.AddWithValue("@elementId", idValue);
                    command.Parameters.AddWithValue("@folderId", folderId);
                    command.ExecuteNonQuery();
                }
            }
        }



        private void btSearch_Click(object sender, EventArgs e) {
            applySearch();
        }

        private void inputSearch_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                applySearch();
                inputSearch.SelectAll();
            }
        }

        private void applySearch() {
            searchStr = inputSearch.Text.Trim();
            loadElementsFromDb();
        }

        private void inputSearch_Click(object sender, EventArgs e) {
            if (inputSearch.SelectionLength == 0) {
                inputSearch.SelectAll();
            }
            
        }

        private void menuOpen_Click(object sender, EventArgs e) {
            btOpen_Click(sender, e);
        }

        private void menuQuit_Click(object sender, EventArgs e) {
            btExit_Click(sender, e);
        }

        public int getProgress() {
            return progress.Value;
        }

        public void startProgress(int max) {
            progress.Value = 0;
            progress.Maximum = max;
            progress.Visible = true;
        }

        public void stepProgress() {
            progress.Value++;
        }

        public void clearProgress() {
            progress.Value = 0;
            progress.Visible = false;
        }

        public void setStatusText(string text) {
            statusLabel.Text = text;
        }

        private void btFirst_Click(object sender, EventArgs e) {
            currentPage = 0;
            loadElementsFromDb();
        }

        private void btLast_Click(object sender, EventArgs e) {
            currentPage = totalPages - 1;
            loadElementsFromDb();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}