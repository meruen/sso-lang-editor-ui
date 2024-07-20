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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            somethingToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            menuSave = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            menuQuit = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            progress = new ToolStripProgressBar();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btOpen = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btSave = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btExit = new ToolStripButton();
            btSearch = new ToolStripButton();
            inputSearch = new ToolStripTextBox();
            splitContainer = new SplitContainer();
            foldersList = new ListBox();
            panelGrid = new Panel();
            dataGrid = new DataGridView();
            keyColumn = new DataGridViewTextBoxColumn();
            colOriginal = new DataGridViewTextBoxColumn();
            translationColumn = new DataGridViewTextBoxColumn();
            idColumn = new DataGridViewTextBoxColumn();
            folderIdColumn = new DataGridViewTextBoxColumn();
            panelNavigation = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btLast = new Button();
            btNext = new Button();
            textPage = new Label();
            btPrev = new Button();
            btFirst = new Button();
            contextMenuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            panelNavigation.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { somethingToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(133, 26);
            // 
            // somethingToolStripMenuItem
            // 
            somethingToolStripMenuItem.Name = "somethingToolStripMenuItem";
            somethingToolStripMenuItem.Size = new Size(132, 22);
            somethingToolStripMenuItem.Text = "Something";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1010, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuOpen, toolStripMenuItem1, menuSave, toolStripMenuItem2, menuQuit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(47, 20);
            menuFile.Text = "File";
            // 
            // menuOpen
            // 
            menuOpen.Name = "menuOpen";
            menuOpen.Size = new Size(102, 22);
            menuOpen.Text = "Open";
            menuOpen.Click += menuOpen_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(99, 6);
            // 
            // menuSave
            // 
            menuSave.Name = "menuSave";
            menuSave.Size = new Size(102, 22);
            menuSave.Text = "Save";
            menuSave.Click += menuSave_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(99, 6);
            // 
            // menuQuit
            // 
            menuQuit.Name = "menuQuit";
            menuQuit.Size = new Size(102, 22);
            menuQuit.Text = "Quit";
            menuQuit.Click += menuQuit_Click;
            // 
            // statusStrip
            // 
            statusStrip.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip.Items.AddRange(new ToolStripItem[] { progress, statusLabel });
            statusStrip.Location = new Point(0, 656);
            statusStrip.Name = "statusStrip";
            statusStrip.RightToLeft = RightToLeft.Yes;
            statusStrip.Size = new Size(1010, 22);
            statusStrip.TabIndex = 3;
            // 
            // progress
            // 
            progress.Name = "progress";
            progress.Size = new Size(100, 16);
            progress.Visible = false;
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 17);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btOpen, toolStripSeparator1, btSave, toolStripSeparator2, btExit, btSearch, inputSearch });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1010, 31);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // btOpen
            // 
            btOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btOpen.Image = Properties.Resources.Folder_Brick;
            btOpen.ImageTransparentColor = Color.Magenta;
            btOpen.Name = "btOpen";
            btOpen.Size = new Size(28, 28);
            btOpen.Text = "Open";
            btOpen.Click += btOpen_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // btSave
            // 
            btSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btSave.Image = Properties.Resources.Save_As;
            btSave.ImageTransparentColor = Color.Magenta;
            btSave.Name = "btSave";
            btSave.Size = new Size(28, 28);
            btSave.Text = "Save";
            btSave.Click += btSave_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // btExit
            // 
            btExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btExit.Image = Properties.Resources.Door_In;
            btExit.ImageTransparentColor = Color.Magenta;
            btExit.Name = "btExit";
            btExit.Size = new Size(28, 28);
            btExit.Text = "Exit";
            btExit.Click += btExit_Click;
            // 
            // btSearch
            // 
            btSearch.Alignment = ToolStripItemAlignment.Right;
            btSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btSearch.Image = Properties.Resources.Search_Plus;
            btSearch.ImageTransparentColor = Color.Magenta;
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(28, 28);
            btSearch.Text = "Search";
            btSearch.Click += btSearch_Click;
            // 
            // inputSearch
            // 
            inputSearch.Alignment = ToolStripItemAlignment.Right;
            inputSearch.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputSearch.Margin = new Padding(1, 0, 5, 0);
            inputSearch.Name = "inputSearch";
            inputSearch.Size = new Size(220, 31);
            inputSearch.ToolTipText = "Search";
            inputSearch.KeyUp += inputSearch_KeyUp;
            inputSearch.MouseDown += inputSearch_MouseDown;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 55);
            splitContainer.Margin = new Padding(10, 9, 10, 9);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(foldersList);
            splitContainer.Panel1.Padding = new Padding(10, 9, 5, 9);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(panelGrid);
            splitContainer.Panel2.Controls.Add(panelNavigation);
            splitContainer.Panel2.Padding = new Padding(5, 9, 10, 9);
            splitContainer.Size = new Size(1010, 601);
            splitContainer.SplitterDistance = 238;
            splitContainer.TabIndex = 6;
            // 
            // foldersList
            // 
            foldersList.Dock = DockStyle.Fill;
            foldersList.FormattingEnabled = true;
            foldersList.ItemHeight = 14;
            foldersList.Location = new Point(10, 9);
            foldersList.Name = "foldersList";
            foldersList.Size = new Size(223, 583);
            foldersList.TabIndex = 0;
            foldersList.DoubleClick += foldersList_DoubleClick;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dataGrid);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(5, 9);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(753, 551);
            panelGrid.TabIndex = 3;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { keyColumn, colOriginal, translationColumn, idColumn, folderIdColumn });
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGrid.Location = new Point(0, 0);
            dataGrid.Name = "dataGrid";
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(753, 551);
            dataGrid.TabIndex = 0;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            dataGrid.RowValidated += dataGrid_CellEndEdit;
            // 
            // keyColumn
            // 
            keyColumn.HeaderText = "Key";
            keyColumn.Name = "keyColumn";
            keyColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colOriginal
            // 
            colOriginal.HeaderText = "Original";
            colOriginal.Name = "colOriginal";
            // 
            // translationColumn
            // 
            translationColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            translationColumn.HeaderText = "Translation";
            translationColumn.Name = "translationColumn";
            translationColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // idColumn
            // 
            idColumn.HeaderText = "id";
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            idColumn.Visible = false;
            // 
            // folderIdColumn
            // 
            folderIdColumn.HeaderText = "folderId";
            folderIdColumn.Name = "folderIdColumn";
            folderIdColumn.Visible = false;
            // 
            // panelNavigation
            // 
            panelNavigation.Controls.Add(flowLayoutPanel1);
            panelNavigation.Dock = DockStyle.Bottom;
            panelNavigation.Location = new Point(5, 560);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(753, 32);
            panelNavigation.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btLast);
            flowLayoutPanel1.Controls.Add(btNext);
            flowLayoutPanel1.Controls.Add(textPage);
            flowLayoutPanel1.Controls.Add(btPrev);
            flowLayoutPanel1.Controls.Add(btFirst);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(753, 32);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btLast
            // 
            btLast.Enabled = false;
            btLast.Image = Properties.Resources.Control_stop_right_32;
            btLast.Location = new Point(718, 3);
            btLast.Name = "btLast";
            btLast.Size = new Size(32, 23);
            btLast.TabIndex = 4;
            btLast.UseVisualStyleBackColor = true;
            btLast.Click += btLast_Click;
            // 
            // btNext
            // 
            btNext.Enabled = false;
            btNext.Image = Properties.Resources.Control_right_32;
            btNext.Location = new Point(683, 3);
            btNext.Margin = new Padding(3, 3, 0, 3);
            btNext.Name = "btNext";
            btNext.Size = new Size(32, 23);
            btNext.TabIndex = 0;
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // textPage
            // 
            textPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textPage.AutoSize = true;
            textPage.Location = new Point(677, 0);
            textPage.Name = "textPage";
            textPage.Size = new Size(0, 29);
            textPage.TabIndex = 2;
            textPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btPrev
            // 
            btPrev.Enabled = false;
            btPrev.Image = Properties.Resources.Control_left_32;
            btPrev.Location = new Point(639, 3);
            btPrev.Name = "btPrev";
            btPrev.Size = new Size(32, 23);
            btPrev.TabIndex = 1;
            btPrev.UseVisualStyleBackColor = true;
            btPrev.Click += btPrev_Click;
            // 
            // btFirst
            // 
            btFirst.Enabled = false;
            btFirst.Image = Properties.Resources.Control_stop_left_32;
            btFirst.Location = new Point(604, 3);
            btFirst.Margin = new Padding(3, 3, 0, 3);
            btFirst.Name = "btFirst";
            btFirst.Size = new Size(32, 23);
            btFirst.TabIndex = 3;
            btFirst.UseVisualStyleBackColor = true;
            btFirst.Click += btFirst_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 678);
            Controls.Add(splitContainer);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "fMain";
            Text = "SSO - Lang Editor UI";
            Load += fMain_Load;
            contextMenuStrip2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            panelNavigation.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btFirst;
        private Button btLast;
        private DataGridViewTextBoxColumn keyColumn;
        private DataGridViewTextBoxColumn colOriginal;
        private DataGridViewTextBoxColumn translationColumn;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn folderIdColumn;
    }
}