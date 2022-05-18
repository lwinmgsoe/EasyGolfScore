namespace EasyGolfScore.Controls
{
    partial class ScroeTable
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoleNumber = new System.Windows.Forms.TextBox();
            this.dgStroke = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStroke)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPlayerNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoleNumber);
            this.groupBox1.Controls.Add(this.dgStroke);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 235);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ရိုက်ချက်များ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ကစားသမားအရေအတွက်";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPlayerNo
            // 
            this.txtPlayerNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayerNo.Location = new System.Drawing.Point(983, 26);
            this.txtPlayerNo.Name = "txtPlayerNo";
            this.txtPlayerNo.Size = new System.Drawing.Size(125, 27);
            this.txtPlayerNo.TabIndex = 3;
            this.txtPlayerNo.Text = "20";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1770, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ကျင်းအရေအတွက်";
            // 
            // txtHoleNumber
            // 
            this.txtHoleNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoleNumber.Location = new System.Drawing.Point(1884, 26);
            this.txtHoleNumber.Name = "txtHoleNumber";
            this.txtHoleNumber.Size = new System.Drawing.Size(125, 27);
            this.txtHoleNumber.TabIndex = 1;
            this.txtHoleNumber.Text = "18";
            // 
            // dgStroke
            // 
            this.dgStroke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgStroke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStroke.Location = new System.Drawing.Point(6, 81);
            this.dgStroke.Name = "dgStroke";
            this.dgStroke.RowHeadersWidth = 51;
            this.dgStroke.RowTemplate.Height = 29;
            this.dgStroke.Size = new System.Drawing.Size(1102, 144);
            this.dgStroke.TabIndex = 0;
            // 
            // ScroeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ScroeTable";
            this.Size = new System.Drawing.Size(1114, 244);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStroke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtHoleNumber;
        private DataGridView dgStroke;
        private Label label1;
        private TextBox txtPlayerNo;
    }
}
