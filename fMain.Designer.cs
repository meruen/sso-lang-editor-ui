namespace sso_lang_editor_ui {
    partial class fMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.somethingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btExit = new System.Windows.Forms.ToolStripButton();
            this.btSearch = new System.Windows.Forms.ToolStripButton();
            this.inputSearch = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.foldersList = new System.Windows.Forms.ListBox();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.keyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btLast = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.textPage = new System.Windows.Forms.Label();
            this.btPrev = new System.Windows.Forms.Button();
            this.btFirst = new System.Windows.Forms.Button();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panelNavigation.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somethingToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(133, 26);
            // 
            // somethingToolStripMenuItem
            // 
            this.somethingToolStripMenuItem.Name = "somethingToolStripMenuItem";
            this.somethingToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.somethingToolStripMenuItem.Text = "Something";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.toolStripMenuItem1,
            this.menuSave,
            this.toolStripMenuItem2,
            this.menuQuit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(47, 20);
            this.menuFile.Text = "File";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(102, 22);
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 6);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(102, 22);
            this.menuSave.Text = "Save";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(99, 6);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(102, 22);
            this.menuQuit.Text = "Quit";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progress,
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 656);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(1010, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(100, 16);
            this.progress.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btOpen,
            this.toolStripSeparator1,
            this.btSave,
            this.toolStripSeparator2,
            this.btExit,
            this.btSearch,
            this.inputSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1010, 31);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btOpen
            // 
            this.btOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btOpen.Image = global::sso_lang_editor_ui.Properties.Resources.Folder_Brick;
            this.btOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(28, 28);
            this.btOpen.Text = "Open";
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btSave
            // 
            this.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSave.Image = global::sso_lang_editor_ui.Properties.Resources.Save_As;
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(28, 28);
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btExit
            // 
            this.btExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExit.Image = global::sso_lang_editor_ui.Properties.Resources.Door_In;
            this.btExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(28, 28);
            this.btExit.Text = "Exit";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btSearch
            // 
            this.btSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSearch.Image = global::sso_lang_editor_ui.Properties.Resources.Search_Plus;
            this.btSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(28, 28);
            this.btSearch.Text = "Search";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // inputSearch
            // 
            this.inputSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.inputSearch.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(1, 0, 5, 0);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(220, 31);
            this.inputSearch.ToolTipText = "Search";
            this.inputSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputSearch_KeyUp);
            this.inputSearch.Click += new System.EventHandler(this.inputSearch_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 55);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.foldersList);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10, 9, 5, 9);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelGrid);
            this.splitContainer.Panel2.Controls.Add(this.panelNavigation);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(5, 9, 10, 9);
            this.splitContainer.Size = new System.Drawing.Size(1010, 601);
            this.splitContainer.SplitterDistance = 238;
            this.splitContainer.TabIndex = 6;
            // 
            // foldersList
            // 
            this.foldersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foldersList.FormattingEnabled = true;
            this.foldersList.ItemHeight = 14;
            this.foldersList.Location = new System.Drawing.Point(10, 9);
            this.foldersList.Name = "foldersList";
            this.foldersList.Size = new System.Drawing.Size(223, 583);
            this.foldersList.TabIndex = 0;
            this.foldersList.DoubleClick += new System.EventHandler(this.foldersList_DoubleClick);
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataGrid);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(5, 9);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(753, 551);
            this.panelGrid.TabIndex = 3;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyColumn,
            this.translationColumn,
            this.idColumn,
            this.folderIdColumn});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(753, 551);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellEndEdit);
            // 
            // keyColumn
            // 
            this.keyColumn.HeaderText = "Key";
            this.keyColumn.Name = "keyColumn";
            this.keyColumn.ReadOnly = true;
            this.keyColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.keyColumn.Width = 200;
            // 
            // translationColumn
            // 
            this.translationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.translationColumn.HeaderText = "Translation";
            this.translationColumn.Name = "translationColumn";
            this.translationColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // folderIdColumn
            // 
            this.folderIdColumn.HeaderText = "folderId";
            this.folderIdColumn.Name = "folderIdColumn";
            this.folderIdColumn.Visible = false;
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.flowLayoutPanel1);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNavigation.Location = new System.Drawing.Point(5, 560);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(753, 32);
            this.panelNavigation.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btLast);
            this.flowLayoutPanel1.Controls.Add(this.btNext);
            this.flowLayoutPanel1.Controls.Add(this.textPage);
            this.flowLayoutPanel1.Controls.Add(this.btPrev);
            this.flowLayoutPanel1.Controls.Add(this.btFirst);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(753, 32);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btLast
            // 
            this.btLast.Enabled = false;
            this.btLast.Image = global::sso_lang_editor_ui.Properties.Resources.Control_stop_right_32;
            this.btLast.Location = new System.Drawing.Point(718, 3);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(32, 23);
            this.btLast.TabIndex = 4;
            this.btLast.UseVisualStyleBackColor = true;
            this.btLast.Click += new System.EventHandler(this.btLast_Click);
            // 
            // btNext
            // 
            this.btNext.Enabled = false;
            this.btNext.Image = global::sso_lang_editor_ui.Properties.Resources.Control_right_32;
            this.btNext.Location = new System.Drawing.Point(683, 3);
            this.btNext.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(32, 23);
            this.btNext.TabIndex = 0;
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // textPage
            // 
            this.textPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textPage.AutoSize = true;
            this.textPage.Location = new System.Drawing.Point(677, 0);
            this.textPage.Name = "textPage";
            this.textPage.Size = new System.Drawing.Size(0, 29);
            this.textPage.TabIndex = 2;
            this.textPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPrev
            // 
            this.btPrev.Enabled = false;
            this.btPrev.Image = global::sso_lang_editor_ui.Properties.Resources.Control_left_32;
            this.btPrev.Location = new System.Drawing.Point(639, 3);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(32, 23);
            this.btPrev.TabIndex = 1;
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btFirst
            // 
            this.btFirst.Enabled = false;
            this.btFirst.Image = global::sso_lang_editor_ui.Properties.Resources.Control_stop_left_32;
            this.btFirst.Location = new System.Drawing.Point(604, 3);
            this.btFirst.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(32, 23);
            this.btFirst.TabIndex = 3;
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 678);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMain";
            this.Text = "SSO - Lang Editor UI";
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem somethingToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuOpen;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menuSave;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem menuQuit;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolStrip toolStrip1;
        private ToolStripButton btOpen;
        private ToolStripButton btSave;
        private ToolStripButton btExit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private SplitContainer splitContainer;
        private ListBox foldersList;
        private ToolStripProgressBar progress;
        private DataGridView dataGrid;
        private ToolStripStatusLabel statusLabel;
        private ToolStripButton btSearch;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btNext;
        private Button btPrev;
        private Label textPage;
        private Panel panelNavigation;
        private Panel panelGrid;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox inputSearch;
        private DataGridViewTextBoxColumn keyColumn;
        private DataGridViewTextBoxColumn translationColumn;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn folderIdColumn;
        private Button btFirst;
        private Button btLast;
    }
}