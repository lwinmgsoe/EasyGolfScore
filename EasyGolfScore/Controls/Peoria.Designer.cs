namespace EasyGolfScore.Controls
{
    partial class Peoria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.standardHoleAndStrokes = new EasyGolfScore.Controls.StandardHoleAndStrokes();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerNo = new System.Windows.Forms.TextBox();
            this.dgStroke = new System.Windows.Forms.DataGridView();
            this.gridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newGameScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStroke)).BeginInit();
            this.gridMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 64);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(411, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Peoria System";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.standardHoleAndStrokes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 289);
            this.panel2.TabIndex = 1;
            // 
            // standardHoleAndStrokes
            // 
            this.standardHoleAndStrokes.AutoScroll = true;
            this.standardHoleAndStrokes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standardHoleAndStrokes.Location = new System.Drawing.Point(0, 0);
            this.standardHoleAndStrokes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.standardHoleAndStrokes.Name = "standardHoleAndStrokes";
            this.standardHoleAndStrokes.Size = new System.Drawing.Size(1028, 289);
            this.standardHoleAndStrokes.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.btnSort);
            this.panel3.Controls.Add(this.btnCalculate);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 1081);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(11, 16, 11, 16);
            this.panel3.Size = new System.Drawing.Size(1028, 90);
            this.panel3.TabIndex = 2;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(260, 18);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(106, 43);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "E&xport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(148, 18);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(106, 43);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "&Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(36, 18);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 43);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(890, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 363);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(11, 16, 11, 16);
            this.panel4.Size = new System.Drawing.Size(1028, 718);
            this.panel4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPlayerNo);
            this.groupBox1.Controls.Add(this.dgStroke);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(11, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1006, 686);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ရိုက်ချက်များ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "ကစားသမားအရေအတွက်";
            // 
            // txtPlayerNo
            // 
            this.txtPlayerNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayerNo.Location = new System.Drawing.Point(844, 40);
            this.txtPlayerNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayerNo.Name = "txtPlayerNo";
            this.txtPlayerNo.Size = new System.Drawing.Size(140, 37);
            this.txtPlayerNo.TabIndex = 1;
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
            this.dgStroke.Location = new System.Drawing.Point(25, 109);
            this.dgStroke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgStroke.Name = "dgStroke";
            this.dgStroke.RowHeadersWidth = 51;
            this.dgStroke.RowTemplate.Height = 29;
            this.dgStroke.Size = new System.Drawing.Size(960, 554);
            this.dgStroke.TabIndex = 0;
            this.dgStroke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgStroke.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStroke_CellEndEdit);
            this.dgStroke.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgStroke_CellMouseClick);
            this.dgStroke.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgStroke_CellMouseDown);
            this.dgStroke.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgStroke_MouseClick);
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
            this.gridMenu.Text = "Scroe Menu";
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
            // Peoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Peoria";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1048, 1181);
            this.Load += new System.EventHandler(this.Peoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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

        private Panel panel1;
        private Panel panel2;
        private StandardHoleAndStrokes standardHoleAndStrokes;
        private Panel panel3;
        private Panel panel4;
        private GroupBox groupBox1;
        private DataGridView dgStroke;
        private TextBox txtPlayerNo;
        private Button button1;
        private Button btnCalculate;
        private Button btnSort;
        private Button btnExport;
        private ContextMenuStrip gridMenu;
        private ToolStripMenuItem addNewRowToolStripMenuItem;
        private ToolStripMenuItem deleteRowToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem newGameScoreToolStripMenuItem;
        private ToolStripMenuItem clearAllToolStripMenuItem;
        private Label label1;
        private Label label2;
    }
}
