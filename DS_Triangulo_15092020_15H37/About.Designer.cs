namespace DS_Triangulo_15092020_15H37
{
    partial class fmrAbout
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.llbGithub = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGithub = new System.Windows.Forms.Label();
            this.lblLinkedin = new System.Windows.Forms.Label();
            this.llbLinkedin = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DS_Triangulo_15092020_15H37.Properties.Resources.IMG_20190913_223541_869;
            this.pictureBox1.Location = new System.Drawing.Point(79, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matheus dos Santos Bonifacio";
            // 
            // llbGithub
            // 
            this.llbGithub.AutoSize = true;
            this.llbGithub.Location = new System.Drawing.Point(99, 194);
            this.llbGithub.Name = "llbGithub";
            this.llbGithub.Size = new System.Drawing.Size(165, 13);
            this.llbGithub.TabIndex = 2;
            this.llbGithub.TabStop = true;
            this.llbGithub.Text = "https://github.com/caneladeouro";
            this.llbGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGithub_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Caneladeouro10@gmail.com";
            // 
            // lblGithub
            // 
            this.lblGithub.AutoSize = true;
            this.lblGithub.Location = new System.Drawing.Point(55, 194);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(38, 13);
            this.lblGithub.TabIndex = 5;
            this.lblGithub.Text = "Github";
            // 
            // lblLinkedin
            // 
            this.lblLinkedin.AutoSize = true;
            this.lblLinkedin.Location = new System.Drawing.Point(133, 226);
            this.lblLinkedin.Name = "lblLinkedin";
            this.lblLinkedin.Size = new System.Drawing.Size(47, 13);
            this.lblLinkedin.TabIndex = 6;
            this.lblLinkedin.Text = "Linkedin";
            // 
            // llbLinkedin
            // 
            this.llbLinkedin.AutoSize = true;
            this.llbLinkedin.Location = new System.Drawing.Point(12, 239);
            this.llbLinkedin.Name = "llbLinkedin";
            this.llbLinkedin.Size = new System.Drawing.Size(298, 13);
            this.llbLinkedin.TabIndex = 7;
            this.llbLinkedin.TabStop = true;
            this.llbLinkedin.Text = "https://www.linkedin.com/in/matheus-dos-santos-897268193";
            // 
            // fmrAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.llbLinkedin);
            this.Controls.Add(this.lblLinkedin);
            this.Controls.Add(this.lblGithub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llbGithub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fmrAbout";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbGithub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGithub;
        private System.Windows.Forms.Label lblLinkedin;
        private System.Windows.Forms.LinkLabel llbLinkedin;
    }
}