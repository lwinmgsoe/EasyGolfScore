namespace EasyGolfScore.Controls
{
    partial class System36
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.standardHoleAndStrokes = new EasyGolfScore.Controls.StandardHoleAndStrokes();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlayerNo = new System.Windows.Forms.TextBox();
            this.dgStroke = new System.Windows.Forms.DataGridView();
            this.gridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newGameScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStroke)).BeginInit();
            this.gridMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.label1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1255, 50);
            this.Header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(518, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "System 36";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.standardHoleAndStrokes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 291);
            this.panel1.TabIndex = 1;
            // 
            // standardHoleAndStrokes
            // 
            this.standardHoleAndStrokes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standardHoleAndStrokes.Location = new System.Drawing.Point(0, 0);
            this.standardHoleAndStrokes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.standardHoleAndStrokes.Name = "standardHoleAndStrokes";
            this.standardHoleAndStrokes.Size = new System.Drawing.Size(1255, 291);
            this.standardHoleAndStrokes.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnSort);
            this.panel2.Controls.Add(this.btnCalculate);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Pyidaungsu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(0, 631);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 115);
            this.panel2.TabIndex = 2;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(242, 21);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(106, 43);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "E&xport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(130, 21);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(106, 43);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "&Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(18, 21);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 43);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1133, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 341);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1255, 290);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1255, 290);
            this.panel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPlayerNo);
            this.groupBox1.Controls.Add(this.dgStroke);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1255, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ရိုက်ချက်များ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(911, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "ကစားသမားအရေအတွက်";
            // 
            // txtPlayerNo
            // 
            this.txtPlayerNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayerNo.Location = new System.Drawing.Point(1099, 29);
            this.txtPlayerNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayerNo.Name = "txtPlayerNo";
            this.txtPlayerNo.Size = new System.Drawing.Size(140, 36);
            this.txtPlayerNo.TabIndex = 3;
            this.txtPlayerNo.Text = "20";
            this.txtPlayerNo.TextChanged += new System.EventHandler(this.txtPlayerNo_TextChanged);
            // 
            // dgStroke
            // 
            this.dgStroke.AllowUserToAddRows = false;
            this.dgStroke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgStroke.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgStroke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgStroke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Pyidaungsu", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgStroke.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgStroke.Location = new System.Drawing.Point(19, 73);
            this.dgStroke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgStroke.Name = "dgStroke";
            this.dgStroke.RowHeadersWidth = 51;
            this.dgStroke.RowTemplate.Height = 29;
            this.dgStroke.Size = new System.Drawing.Size(1220, 208);
            this.dgStroke.TabIndex = 1;
            this.dgStroke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStroke_CellContentClick);
            this.dgStroke.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStroke_CellEndEdit);
            this.dgStroke.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgStroke_CellMouseClick);
            this.dgStroke.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgStroke_CellMouseDown);
            // 
            // gridMenu
            // 
            this.gridMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRowToolStripMenuItem,
            this.deleteRowToolStripMenuItem,
            this.toolStripSeparator1,
            this.newGameScoreToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.gridMenu.Name = "gridMenu";
            this.gridMenu.Size = new System.Drawing.Size(193, 106);
            // 
            // addNewRowToolStripMenuItem
            // 
            this.addNewRowToolStripMenuItem.Name = "addNewRowToolStripMenuItem";
            this.addNewRowToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.addNewRowToolStripMenuItem.Text = "Add New Row";
            this.addNewRowToolStripMenuItem.Click += new System.EventHandler(this.addNewRowToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // newGameScoreToolStripMenuItem
            // 
            this.newGameScoreToolStripMenuItem.Name = "newGameScoreToolStripMenuItem";
            this.newGameScoreToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.newGameScoreToolStripMenuItem.Text = "New Game Score";
            this.newGameScoreToolStripMenuItem.Click += new System.EventHandler(this.newGameScoreToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // System36
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Pyidaungsu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "System36";
            this.Size = new System.Drawing.Size(1255, 746);
            this.Load += new System.EventHandler(this.System36_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStroke)).EndInit();
            this.gridMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Header;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private GroupBox groupBox1;
        private DataGridView dgStroke;
        private Label label2;
        private TextBox txtPlayerNo;
        private StandardHoleAndStrokes standardHoleAndStrokes;
        private Button btnExport;
        private Button btnSort;
        private Button btnCalculate;
        private Button button1;
        private ContextMenuStrip gridMenu;
        private ToolStripMenuItem addNewRowToolStripMenuItem;
        private ToolStripMenuItem deleteRowToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem newGameScoreToolStripMenuItem;
        private ToolStripMenuItem clearAllToolStripMenuItem;
        private Label label1;
    }
}
