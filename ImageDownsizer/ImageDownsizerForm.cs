using ImageDownsizer.Algorithms;
using System.Diagnostics;

namespace ImageDownsizer
{
    public partial class ImageDownsizerForm : Form
    {
        private Bitmap originalImage;
        private Bitmap downsizedImage;
        public ImageDownsizerForm()
        {
            InitializeComponent();
        }

        private void OpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                originalImage = new Bitmap(selectedFileName);
                pbStartImage.Image = originalImage;
            }

        }

        private void Resize_Click(object sender, EventArgs e)
        {
            if (pbStartImage.Image == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }
            int num;
            if (!int.TryParse(ImageScale.Text, out num) || num <= 0 || num > 99)
            {
                MessageBox.Show("Invalid Image Scale");
                return;
            }

            double scaleFactor = double.Parse(ImageScale.Text) / 100.0;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            Bitmap resizedImage = SimpleResizer.ResizeImage(originalImage, scaleFactor);

            ConsequentialTime.Text = sw.Elapsed.ToString();
            pbStartImage.Image = downsizedImage = resizedImage;

            sw.Restart();

            Bitmap MultiThreadedImage = Worker.ParallelResizing(originalImage, scaleFactor, SimpleResizer.ResizeImage);

            ParallelTime.Text = sw.Elapsed.ToString();

            MessageBox.Show("You Resized the image by " + ImageScale.Text + "%");
        }

        private void ImageDownsizerForm_Load(object sender, EventArgs e)
        {

        }

        private void ImageScale_Enter(object sender, EventArgs e)
        {
            if (ImageScale.Text == "Image Scale")
            {
                ImageScale.Text = "";
                ImageScale.ForeColor = Color.Black;
            }
        }

        private void ImageScale_Leave(object sender, EventArgs e)
        {
            if (ImageScale.Text == "")
            {
                ImageScale.Text = "Image Scale";
                ImageScale.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                downsizedImage.Save(saveFileDialog.FileName);
            }
        }
    }
}
