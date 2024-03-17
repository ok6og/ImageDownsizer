namespace ImageDownsizer
{
    partial class ImageDownsizerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OpenImage = new Button();
            Resize = new Button();
            textBox1 = new TextBox();
            pbStartImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbStartImage).BeginInit();
            SuspendLayout();
            // 
            // OpenImage
            // 
            OpenImage.Location = new Point(12, 12);
            OpenImage.Name = "OpenImage";
            OpenImage.Size = new Size(82, 23);
            OpenImage.TabIndex = 0;
            OpenImage.Text = "Open Image";
            OpenImage.UseVisualStyleBackColor = true;
            OpenImage.Click += OpenImage_Click;
            // 
            // Resize
            // 
            Resize.Location = new Point(150, 12);
            Resize.Name = "Resize";
            Resize.Size = new Size(75, 23);
            Resize.TabIndex = 1;
            Resize.Text = "Resize";
            Resize.UseVisualStyleBackColor = true;
            Resize.Click += Resize_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pbStartImage
            // 
            pbStartImage.Location = new Point(256, 12);
            pbStartImage.Name = "pbStartImage";
            pbStartImage.Size = new Size(532, 426);
            pbStartImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbStartImage.TabIndex = 3;
            pbStartImage.TabStop = false;
            pbStartImage.Click += pictureBox1_Click;
            // 
            // ImageDownsizerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbStartImage);
            Controls.Add(textBox1);
            Controls.Add(Resize);
            Controls.Add(OpenImage);
            Name = "ImageDownsizerForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbStartImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenImage;
        private Button Resize;
        private TextBox textBox1;
        private PictureBox pbStartImage;
    }
}
