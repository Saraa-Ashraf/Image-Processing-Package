namespace CsharpGUI
{
    partial class Grayscale_form
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
            this.graysc_save_btn = new System.Windows.Forms.Button();
            this.pic_Box_graysc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Box_graysc)).BeginInit();
            this.SuspendLayout();
            // 
            // graysc_save_btn
            // 
            this.graysc_save_btn.Location = new System.Drawing.Point(416, 588);
            this.graysc_save_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.graysc_save_btn.Name = "graysc_save_btn";
            this.graysc_save_btn.Size = new System.Drawing.Size(162, 42);
            this.graysc_save_btn.TabIndex = 0;
            this.graysc_save_btn.Text = "Save";
            this.graysc_save_btn.UseVisualStyleBackColor = true;
            this.graysc_save_btn.Click += new System.EventHandler(this.graysc_save_btn_Click);
            // 
            // pic_Box_graysc
            // 
            this.pic_Box_graysc.Location = new System.Drawing.Point(18, 20);
            this.pic_Box_graysc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_Box_graysc.Name = "pic_Box_graysc";
            this.pic_Box_graysc.Size = new System.Drawing.Size(1020, 558);
            this.pic_Box_graysc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Box_graysc.TabIndex = 1;
            this.pic_Box_graysc.TabStop = false;
            // 
            // Grayscale_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 647);
            this.Controls.Add(this.pic_Box_graysc);
            this.Controls.Add(this.graysc_save_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Grayscale_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grayscale";
            this.Load += new System.EventHandler(this.Grayscale_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Box_graysc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button graysc_save_btn;
        private System.Windows.Forms.PictureBox pic_Box_graysc;
    }
}