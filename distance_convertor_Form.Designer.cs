namespace IA2_CALCULATOR_srfn
{
    partial class distance_convertor_Form
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
            this.BtnReset2 = new System.Windows.Forms.Button();
            this.TBmilesTOkms = new System.Windows.Forms.TextBox();
            this.BtnClose2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReset2
            // 
            this.BtnReset2.Location = new System.Drawing.Point(194, 237);
            this.BtnReset2.Name = "BtnReset2";
            this.BtnReset2.Size = new System.Drawing.Size(100, 25);
            this.BtnReset2.TabIndex = 0;
            this.BtnReset2.Text = "Reset";
            this.BtnReset2.UseVisualStyleBackColor = true;
            this.BtnReset2.Click += new System.EventHandler(this.BtnReset2_Click);
            // 
            // TBmilesTOkms
            // 
            this.TBmilesTOkms.Location = new System.Drawing.Point(194, 128);
            this.TBmilesTOkms.Name = "TBmilesTOkms";
            this.TBmilesTOkms.Size = new System.Drawing.Size(100, 20);
            this.TBmilesTOkms.TabIndex = 1;
            this.TBmilesTOkms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnClose2
            // 
            this.BtnClose2.Location = new System.Drawing.Point(194, 268);
            this.BtnClose2.Name = "BtnClose2";
            this.BtnClose2.Size = new System.Drawing.Size(100, 25);
            this.BtnClose2.TabIndex = 4;
            this.BtnClose2.Text = "Close";
            this.BtnClose2.UseVisualStyleBackColor = true;
            this.BtnClose2.Click += new System.EventHandler(this.BtnClose2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IA2_CALCULATOR_srfn.Properties.Resources._1kilometer;
            this.pictureBox2.Location = new System.Drawing.Point(314, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IA2_CALCULATOR_srfn.Properties.Resources._1_MILE_srfn;
            this.pictureBox1.Location = new System.Drawing.Point(32, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // distance_convertor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 324);
            this.Controls.Add(this.BtnClose2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBmilesTOkms);
            this.Controls.Add(this.BtnReset2);
            this.Name = "distance_convertor_Form";
            this.Text = "Distance converter ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReset2;
        private System.Windows.Forms.TextBox TBmilesTOkms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnClose2;
    }
}