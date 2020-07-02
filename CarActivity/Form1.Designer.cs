namespace CarActivity
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.LexusPicture = new System.Windows.Forms.PictureBox();
            this.BMWPicture = new System.Windows.Forms.PictureBox();
            this.ToyotaPicture = new System.Windows.Forms.PictureBox();
            this.MercedesPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LexusPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMWPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToyotaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MercedesPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LexusPicture
            // 
            this.LexusPicture.Image = ((System.Drawing.Image)(resources.GetObject("LexusPicture.Image")));
            this.LexusPicture.Location = new System.Drawing.Point(46, 34);
            this.LexusPicture.Name = "LexusPicture";
            this.LexusPicture.Size = new System.Drawing.Size(100, 50);
            this.LexusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LexusPicture.TabIndex = 1;
            this.LexusPicture.TabStop = false;
            // 
            // BMWPicture
            // 
            this.BMWPicture.Image = ((System.Drawing.Image)(resources.GetObject("BMWPicture.Image")));
            this.BMWPicture.Location = new System.Drawing.Point(205, 34);
            this.BMWPicture.Name = "BMWPicture";
            this.BMWPicture.Size = new System.Drawing.Size(100, 50);
            this.BMWPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BMWPicture.TabIndex = 2;
            this.BMWPicture.TabStop = false;
            // 
            // ToyotaPicture
            // 
            this.ToyotaPicture.Image = ((System.Drawing.Image)(resources.GetObject("ToyotaPicture.Image")));
            this.ToyotaPicture.Location = new System.Drawing.Point(337, 34);
            this.ToyotaPicture.Name = "ToyotaPicture";
            this.ToyotaPicture.Size = new System.Drawing.Size(100, 50);
            this.ToyotaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ToyotaPicture.TabIndex = 3;
            this.ToyotaPicture.TabStop = false;
            // 
            // MercedesPicture
            // 
            this.MercedesPicture.Image = ((System.Drawing.Image)(resources.GetObject("MercedesPicture.Image")));
            this.MercedesPicture.Location = new System.Drawing.Point(489, 34);
            this.MercedesPicture.Name = "MercedesPicture";
            this.MercedesPicture.Size = new System.Drawing.Size(100, 50);
            this.MercedesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MercedesPicture.TabIndex = 4;
            this.MercedesPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MercedesPicture);
            this.Controls.Add(this.ToyotaPicture);
            this.Controls.Add(this.BMWPicture);
            this.Controls.Add(this.LexusPicture);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LexusPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMWPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToyotaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MercedesPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox LexusPicture;
        private System.Windows.Forms.PictureBox BMWPicture;
        private System.Windows.Forms.PictureBox ToyotaPicture;
        private System.Windows.Forms.PictureBox MercedesPicture;
    }
}

