namespace EasyGolfScore.Controls
{
    partial class HomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewPeoria = new System.Windows.Forms.Button();
            this.btnOldPeoria = new System.Windows.Forms.Button();
            this.btnHandicup = new System.Windows.Forms.Button();
            this.btnSystem36 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 134);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(530, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "EASY GOLF SCORE";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 747);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 21);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNewPeoria);
            this.panel3.Controls.Add(this.btnOldPeoria);
            this.panel3.Controls.Add(this.btnHandicup);
            this.panel3.Controls.Add(this.btnSystem36);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1232, 613);
            this.panel3.TabIndex = 2;
            // 
            // btnNewPeoria
            // 
            this.btnNewPeoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewPeoria.Location = new System.Drawing.Point(101, 417);
            this.btnNewPeoria.Name = "btnNewPeoria";
            this.btnNewPeoria.Size = new System.Drawing.Size(249, 89);
            this.btnNewPeoria.TabIndex = 4;
            this.btnNewPeoria.Text = "New Peoria System";
            this.btnNewPeoria.UseVisualStyleBackColor = true;
            this.btnNewPeoria.Click += new System.EventHandler(this.btnNewPeoria_Click);
            // 
            // btnOldPeoria
            // 
            this.btnOldPeoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOldPeoria.Location = new System.Drawing.Point(101, 305);
            this.btnOldPeoria.Name = "btnOldPeoria";
            this.btnOldPeoria.Size = new System.Drawing.Size(249, 89);
            this.btnOldPeoria.TabIndex = 3;
            this.btnOldPeoria.Text = "Peoria System";
            this.btnOldPeoria.UseVisualStyleBackColor = true;
            this.btnOldPeoria.Click += new System.EventHandler(this.btnOldPeoria_Click);
            // 
            // btnHandicup
            // 
            this.btnHandicup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHandicup.Location = new System.Drawing.Point(101, 200);
            this.btnHandicup.Name = "btnHandicup";
            this.btnHandicup.Size = new System.Drawing.Size(249, 89);
            this.btnHandicup.TabIndex = 2;
            this.btnHandicup.Text = "Handicap System";
            this.btnHandicup.UseVisualStyleBackColor = true;
            this.btnHandicup.Click += new System.EventHandler(this.btnHandicup_Click);
            // 
            // btnSystem36
            // 
            this.btnSystem36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSystem36.Location = new System.Drawing.Point(101, 94);
            this.btnSystem36.Name = "btnSystem36";
            this.btnSystem36.Size = new System.Drawing.Size(249, 89);
            this.btnSystem36.TabIndex = 1;
            this.btnSystem36.Text = "System 36";
            this.btnSystem36.UseVisualStyleBackColor = true;
            this.btnSystem36.Click += new System.EventHandler(this.btnSystem36_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::EasyGolfScore.Properties.Resources.istockphoto_1286102183_170667a;
            this.pictureBox1.Location = new System.Drawing.Point(458, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(729, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1232, 768);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btnNewPeoria;
        private Button btnOldPeoria;
        private Button btnHandicup;
        private Button btnSystem36;
        private PictureBox pictureBox1;
    }
}
