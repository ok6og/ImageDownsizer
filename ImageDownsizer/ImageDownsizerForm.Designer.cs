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
            ParallelPB = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbStartImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ParallelPB).BeginInit();
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
            ImageScale.Size = new Size(75, 23);
            ImageScale.TabIndex = 2;
            ImageScale.Text = "Image Scale";
            ImageScale.Enter += ImageScale_Enter;
            ImageScale.Leave += ImageScale_Leave;
            // 
            // pbStartImage
            // 
            pbStartImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbStartImage.Location = new Point(256, 29);
            pbStartImage.Name = "pbStartImage";
            pbStartImage.Size = new Size(352, 227);
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
            // ParallelPB
            // 
            ParallelPB.Location = new Point(256, 290);
            ParallelPB.Name = "ParallelPB";
            ParallelPB.Size = new Size(352, 240);
            ParallelPB.SizeMode = PictureBoxSizeMode.Zoom;
            ParallelPB.TabIndex = 9;
            ParallelPB.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 9);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 10;
            label3.Text = "Consequental";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 272);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 11;
            label4.Text = "Parallel";
            // 
            // ImageDownsizerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 542);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ParallelPB);
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
            ((System.ComponentModel.ISupportInitialize)ParallelPB).EndInit();
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
        private PictureBox ParallelPB;
        private Label label3;
        private Label label4;
    }
}
