namespace SaveChangesInTextFile
{
    partial class MyNoteBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyNoteBook));
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nigthModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.noteBook = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lineCount = new System.Windows.Forms.Label();
            this.simbolCount = new System.Windows.Forms.Label();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.radioNight1 = new System.Windows.Forms.RadioButton();
            this.radioNight2 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.Menu.ForeColor = System.Drawing.SystemColors.Info;
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(53, 29);
            this.Menu.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click_1);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.MenuSaveas_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.helpToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(421, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayModeToolStripMenuItem,
            this.nigthModeToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // dayModeToolStripMenuItem
            // 
            this.dayModeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dayModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dayModeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dayModeToolStripMenuItem.Image")));
            this.dayModeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.dayModeToolStripMenuItem.Name = "dayModeToolStripMenuItem";
            this.dayModeToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.dayModeToolStripMenuItem.Text = "Day Mode";
            this.dayModeToolStripMenuItem.Click += new System.EventHandler(this.dayModeToolStripMenuItem_Click);
            // 
            // nigthModeToolStripMenuItem
            // 
            this.nigthModeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nigthModeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nigthModeToolStripMenuItem.Image")));
            this.nigthModeToolStripMenuItem.Name = "nigthModeToolStripMenuItem";
            this.nigthModeToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.nigthModeToolStripMenuItem.Text = "Nigth Mode";
            this.nigthModeToolStripMenuItem.Click += new System.EventHandler(this.nigthModeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Info;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // noteBook
            // 
            this.noteBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteBook.BackColor = System.Drawing.Color.Linen;
            this.noteBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteBook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.noteBook.ForeColor = System.Drawing.Color.Black;
            this.noteBook.Location = new System.Drawing.Point(0, 36);
            this.noteBook.Name = "noteBook";
            this.noteBook.Size = new System.Drawing.Size(421, 389);
            this.noteBook.TabIndex = 1;
            this.noteBook.Text = "";
            this.noteBook.TextChanged += new System.EventHandler(this.NoteBook_TextChanges);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lineCount
            // 
            this.lineCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lineCount.AutoSize = true;
            this.lineCount.BackColor = System.Drawing.Color.Transparent;
            this.lineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lineCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineCount.Location = new System.Drawing.Point(52, 428);
            this.lineCount.Name = "lineCount";
            this.lineCount.Size = new System.Drawing.Size(92, 17);
            this.lineCount.TabIndex = 5;
            this.lineCount.Text = "Line Count: 0";
            // 
            // simbolCount
            // 
            this.simbolCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simbolCount.AutoSize = true;
            this.simbolCount.BackColor = System.Drawing.Color.Transparent;
            this.simbolCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.simbolCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.simbolCount.Location = new System.Drawing.Point(178, 428);
            this.simbolCount.Name = "simbolCount";
            this.simbolCount.Size = new System.Drawing.Size(107, 17);
            this.simbolCount.TabIndex = 6;
            this.simbolCount.Text = "Simbol Count: 0";
            // 
            // r1
            // 
            this.r1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.r1.AutoSize = true;
            this.r1.BackColor = System.Drawing.Color.Transparent;
            this.r1.Location = new System.Drawing.Point(12, 431);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(14, 13);
            this.r1.TabIndex = 7;
            this.r1.TabStop = true;
            this.r1.UseVisualStyleBackColor = false;
            this.r1.CheckedChanged += new System.EventHandler(this.r1_CheckedChanged);
            // 
            // r2
            // 
            this.r2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.r2.AutoSize = true;
            this.r2.BackColor = System.Drawing.Color.Transparent;
            this.r2.Location = new System.Drawing.Point(10, 431);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(14, 13);
            this.r2.TabIndex = 8;
            this.r2.TabStop = true;
            this.r2.UseVisualStyleBackColor = false;
            this.r2.Visible = false;
            this.r2.CheckedChanged += new System.EventHandler(this.r2_CheckedChanged_1);
            // 
            // radioNight1
            // 
            this.radioNight1.AutoSize = true;
            this.radioNight1.BackColor = System.Drawing.Color.Transparent;
            this.radioNight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioNight1.Location = new System.Drawing.Point(357, 11);
            this.radioNight1.Name = "radioNight1";
            this.radioNight1.Size = new System.Drawing.Size(14, 13);
            this.radioNight1.TabIndex = 9;
            this.radioNight1.TabStop = true;
            this.radioNight1.UseVisualStyleBackColor = false;
            this.radioNight1.CheckedChanged += new System.EventHandler(this.radioNight1_CheckedChanged);
            // 
            // radioNight2
            // 
            this.radioNight2.AutoSize = true;
            this.radioNight2.BackColor = System.Drawing.Color.Transparent;
            this.radioNight2.Location = new System.Drawing.Point(357, 11);
            this.radioNight2.Name = "radioNight2";
            this.radioNight2.Size = new System.Drawing.Size(14, 13);
            this.radioNight2.TabIndex = 10;
            this.radioNight2.TabStop = true;
            this.radioNight2.UseVisualStyleBackColor = false;
            this.radioNight2.Visible = false;
            this.radioNight2.CheckedChanged += new System.EventHandler(this.radioNight2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MyNoteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioNight2);
            this.Controls.Add(this.radioNight1);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.simbolCount);
            this.Controls.Add(this.lineCount);
            this.Controls.Add(this.noteBook);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(437, 489);
            this.Name = "MyNoteBook";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteBook";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nigthModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.RichTextBox noteBook;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lineCount;
        private System.Windows.Forms.Label simbolCount;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton radioNight1;
        private System.Windows.Forms.RadioButton radioNight2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

