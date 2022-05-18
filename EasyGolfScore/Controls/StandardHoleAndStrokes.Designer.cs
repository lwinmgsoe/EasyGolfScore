namespace EasyGolfScore.Controls
{
    partial class StandardHoleAndStrokes
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoleNumber = new System.Windows.Forms.TextBox();
            this.dgRecord = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoleNumber);
            this.groupBox1.Controls.Add(this.dgRecord);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Pyidaungsu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1110, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ကျင်းသတ်မှတ်ချက်";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "ကျင်းအရေအတွက်";
            // 
            // txtHoleNumber
            // 
            this.txtHoleNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoleNumber.Location = new System.Drawing.Point(970, 26);
            this.txtHoleNumber.Name = "txtHoleNumber";
            this.txtHoleNumber.Size = new System.Drawing.Size(125, 36);
            this.txtHoleNumber.TabIndex = 1;
            this.txtHoleNumber.Text = "18";
            this.txtHoleNumber.TextChanged += new System.EventHandler(this.txtHoleNumber_TextChanged);
            // 
            // dgRecord
            // 
            this.dgRecord.AllowUserToAddRows = false;
            this.dgRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRecord.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecord.Location = new System.Drawing.Point(18, 76);
            this.dgRecord.Name = "dgRecord";
            this.dgRecord.RowHeadersWidth = 51;
            this.dgRecord.RowTemplate.Height = 29;
            this.dgRecord.Size = new System.Drawing.Size(1077, 103);
            this.dgRecord.TabIndex = 0;
            this.dgRecord.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRecord_CellEndEdit);
            // 
            // StandardHoleAndStrokes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "StandardHoleAndStrokes";
            this.Size = new System.Drawing.Size(1110, 194);
            this.Load += new System.EventHandler(this.StandardHoleAndStrokes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtHoleNumber;
        private DataGridView dgRecord;
    }
}
