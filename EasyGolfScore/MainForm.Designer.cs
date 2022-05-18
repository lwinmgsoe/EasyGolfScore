namespace EasyGolfScore
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Header = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BySystem36Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ByHandicapMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ByPeoriaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Footer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.menuStrip1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1138, 50);
            this.Header.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.BySystem36Menu,
            this.ByHandicapMenu,
            this.toolStripMenuItem1,
            this.ByPeoriaMenu,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(248, 26);
            this.toolStripMenuItem2.Text = "Home Page";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // BySystem36Menu
            // 
            this.BySystem36Menu.Name = "BySystem36Menu";
            this.BySystem36Menu.Size = new System.Drawing.Size(248, 26);
            this.BySystem36Menu.Text = "System 36";
            this.BySystem36Menu.Click += new System.EventHandler(this.BySystem36Menu_Click);
            // 
            // ByHandicapMenu
            // 
            this.ByHandicapMenu.Name = "ByHandicapMenu";
            this.ByHandicapMenu.Size = new System.Drawing.Size(248, 26);
            this.ByHandicapMenu.Text = "Handicap System";
            this.ByHandicapMenu.Click += new System.EventHandler(this.ByHandicapMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.toolStripMenuItem1.Text = "Peoria System (6)";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ByPeoriaMenu
            // 
            this.ByPeoriaMenu.Name = "ByPeoriaMenu";
            this.ByPeoriaMenu.Size = new System.Drawing.Size(248, 26);
            this.ByPeoriaMenu.Text = "New Peoria System (12)";
            this.ByPeoriaMenu.Click += new System.EventHandler(this.ByPeoriaMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(245, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 50);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1138, 851);
            this.MainPanel.TabIndex = 1;
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.label1);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 869);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(1138, 32);
            this.Footer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(1013, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Created by LMS";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 901);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Easy Golf Score";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Header;
        private Panel MainPanel;
        private Panel Footer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem BySystem36Menu;
        private ToolStripMenuItem ByHandicapMenu;
        private ToolStripMenuItem ByPeoriaMenu;
        private Label label1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}