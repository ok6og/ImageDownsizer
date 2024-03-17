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
            ImageScale = new TextBox();
            pbStartImage = new PictureBox();
            Save = new Button();
            label1 = new Label();
            ConsequentialTime = new Label();
            label2 = new Label();
            ParallelTime = new Label();
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
            // ImageScale
            // 
            ImageScale.ForeColor = SystemColors.InactiveCaption;
            ImageScale.Location = new Point(150, 50);
            ImageScale.Name = "ImageScale";
            ImageScale.Size = new Size(100, 23);
            ImageScale.TabIndex = 2;
            ImageScale.Text = "Image Scale";
            ImageScale.Enter += ImageScale_Enter;
            ImageScale.Leave += ImageScale_Leave;
            // 
            // pbStartImage
            // 
            pbStartImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbStartImage.Location = new Point(256, 12);
            pbStartImage.Name = "pbStartImage";
            pbStartImage.Size = new Size(532, 426);
            pbStartImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbStartImage.TabIndex = 3;
            pbStartImage.TabStop = false;
            // 
            // Save
            // 
            Save.Location = new Point(12, 50);
            Save.Name = "Save";
            Save.Size = new Size(82, 23);
            Save.TabIndex = 4;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 144);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 5;
            label1.Text = "Consequential:";
            // 
            // ConsequentialTime
            // 
            ConsequentialTime.AutoSize = true;
            ConsequentialTime.Location = new Point(114, 144);
            ConsequentialTime.Name = "ConsequentialTime";
            ConsequentialTime.Size = new Size(29, 15);
            ConsequentialTime.TabIndex = 6;
            ConsequentialTime.Text = "N/A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 198);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 7;
            label2.Text = "Parallel:";
            // 
            // ParallelTime
            // 
            ParallelTime.AutoSize = true;
            ParallelTime.Location = new Point(114, 198);
            ParallelTime.Name = "ParallelTime";
            ParallelTime.Size = new Size(29, 15);
            ParallelTime.TabIndex = 8;
            ParallelTime.Text = "N/A";
            // 
            // ImageDownsizerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ParallelTime);
            Controls.Add(label2);
            Controls.Add(ConsequentialTime);
            Controls.Add(label1);
            Controls.Add(Save);
            Controls.Add(pbStartImage);
            Controls.Add(ImageScale);
            Controls.Add(Resize);
            Controls.Add(OpenImage);
            Name = "ImageDownsizerForm";
            Text = "Form1";
            Load += ImageDownsizerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbStartImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenImage;
        private Button Resize;
        private TextBox ImageScale;
        private PictureBox pbStartImage;
        private Button Save;
        private Label label1;
        private Label ConsequentialTime;
        private Label label2;
        private Label ParallelTime;
    }
}
