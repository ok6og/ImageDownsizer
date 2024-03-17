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
            NearestNeighborPB = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            NearestNeighborLable = new Label();
            label7 = new Label();
            BIPB = new PictureBox();
            label8 = new Label();
            BilinearInterpolationLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pbStartImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ParallelPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NearestNeighborPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BIPB).BeginInit();
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
            pbStartImage.Location = new Point(256, 29);
            pbStartImage.Name = "pbStartImage";
            pbStartImage.Size = new Size(350, 225);
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
            ConsequentialTime.Location = new Point(150, 144);
            ConsequentialTime.Name = "ConsequentialTime";
            ConsequentialTime.Size = new Size(29, 15);
            ConsequentialTime.TabIndex = 6;
            ConsequentialTime.Text = "N/A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 179);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 7;
            label2.Text = "Parallel:";
            // 
            // ParallelTime
            // 
            ParallelTime.AutoSize = true;
            ParallelTime.Location = new Point(150, 179);
            ParallelTime.Name = "ParallelTime";
            ParallelTime.Size = new Size(29, 15);
            ParallelTime.TabIndex = 8;
            ParallelTime.Text = "N/A";
            // 
            // ParallelPB
            // 
            ParallelPB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ParallelPB.Location = new Point(256, 305);
            ParallelPB.Name = "ParallelPB";
            ParallelPB.Size = new Size(350, 225);
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
            label4.Location = new Point(395, 272);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 11;
            label4.Text = "Parallel";
            // 
            // NearestNeighborPB
            // 
            NearestNeighborPB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NearestNeighborPB.Location = new Point(645, 29);
            NearestNeighborPB.Name = "NearestNeighborPB";
            NearestNeighborPB.Size = new Size(350, 225);
            NearestNeighborPB.SizeMode = PictureBoxSizeMode.Zoom;
            NearestNeighborPB.TabIndex = 12;
            NearestNeighborPB.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(756, 9);
            label5.Name = "label5";
            label5.Size = new Size(173, 15);
            label5.TabIndex = 13;
            label5.Text = "Nearest-Neighbor Interpolation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 211);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 14;
            label6.Text = "Nearest Neighbor:";
            // 
            // NearestNeighborLable
            // 
            NearestNeighborLable.AutoSize = true;
            NearestNeighborLable.Location = new Point(150, 211);
            NearestNeighborLable.Name = "NearestNeighborLable";
            NearestNeighborLable.Size = new Size(29, 15);
            NearestNeighborLable.TabIndex = 15;
            NearestNeighborLable.Text = "N/A";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(778, 272);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 16;
            label7.Text = "Bilinear Interpolation";
            // 
            // BIPB
            // 
            BIPB.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BIPB.Location = new Point(645, 305);
            BIPB.Name = "BIPB";
            BIPB.Size = new Size(350, 225);
            BIPB.SizeMode = PictureBoxSizeMode.Zoom;
            BIPB.TabIndex = 17;
            BIPB.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 239);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 18;
            label8.Text = "Bilinear Interpolation:";
            // 
            // BilinearInterpolationLabel
            // 
            BilinearInterpolationLabel.AutoSize = true;
            BilinearInterpolationLabel.Location = new Point(150, 239);
            BilinearInterpolationLabel.Name = "BilinearInterpolationLabel";
            BilinearInterpolationLabel.Size = new Size(29, 15);
            BilinearInterpolationLabel.TabIndex = 19;
            BilinearInterpolationLabel.Text = "N/A";
            // 
            // ImageDownsizerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 542);
            Controls.Add(BilinearInterpolationLabel);
            Controls.Add(label8);
            Controls.Add(BIPB);
            Controls.Add(label7);
            Controls.Add(NearestNeighborLable);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(NearestNeighborPB);
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
            ((System.ComponentModel.ISupportInitialize)NearestNeighborPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)BIPB).EndInit();
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
        private PictureBox NearestNeighborPB;
        private Label label5;
        private Label label6;
        private Label NearestNeighborLable;
        private Label label7;
        private PictureBox BIPB;
        private Label label8;
        private Label BilinearInterpolationLabel;
    }
}
