namespace CsharpGUI
{
    partial class ImageArithmatic_Form
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
            this.open_img1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.open_img2 = new System.Windows.Forms.Button();
            this.AddImages_btn = new System.Windows.Forms.Button();
            this.subtractImages_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // open_img1
            // 
            this.open_img1.Location = new System.Drawing.Point(1000, 91);
            this.open_img1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.open_img1.Name = "open_img1";
            this.open_img1.Size = new System.Drawing.Size(182, 44);
            this.open_img1.TabIndex = 3;
            this.open_img1.Text = "Open First image";
            this.open_img1.UseVisualStyleBackColor = true;
            this.open_img1.Click += new System.EventHandler(this.open_img_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(18, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(524, 70);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(441, 343);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(264, 436);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(441, 343);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // open_img2
            // 
            this.open_img2.Location = new System.Drawing.Point(1000, 143);
            this.open_img2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.open_img2.Name = "open_img2";
            this.open_img2.Size = new System.Drawing.Size(182, 44);
            this.open_img2.TabIndex = 6;
            this.open_img2.Text = "Open Second Image";
            this.open_img2.UseVisualStyleBackColor = true;
            this.open_img2.Click += new System.EventHandler(this.open_img2_Click);
            // 
            // AddImages_btn
            // 
            this.AddImages_btn.Location = new System.Drawing.Point(1000, 196);
            this.AddImages_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddImages_btn.Name = "AddImages_btn";
            this.AddImages_btn.Size = new System.Drawing.Size(182, 44);
            this.AddImages_btn.TabIndex = 7;
            this.AddImages_btn.Text = "Add Images";
            this.AddImages_btn.UseVisualStyleBackColor = true;
            this.AddImages_btn.Click += new System.EventHandler(this.AddImages_btn_Click);
            // 
            // subtractImages_btn
            // 
            this.subtractImages_btn.Location = new System.Drawing.Point(1000, 248);
            this.subtractImages_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subtractImages_btn.Name = "subtractImages_btn";
            this.subtractImages_btn.Size = new System.Drawing.Size(180, 39);
            this.subtractImages_btn.TabIndex = 8;
            this.subtractImages_btn.Text = "Subtract Images";
            this.subtractImages_btn.UseVisualStyleBackColor = true;
            this.subtractImages_btn.Click += new System.EventHandler(this.subtractImages_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(1000, 297);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(180, 39);
            this.save_btn.TabIndex = 9;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // ImageArithmatic_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 797);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.subtractImages_btn);
            this.Controls.Add(this.AddImages_btn);
            this.Controls.Add(this.open_img2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.open_img1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImageArithmatic_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Arithmatic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_img1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button open_img2;
        private System.Windows.Forms.Button AddImages_btn;
        private System.Windows.Forms.Button subtractImages_btn;
        private System.Windows.Forms.Button save_btn;
    }
}