namespace ImageDownsizer
{
    public partial class ImageDownsizerForm : Form
    {
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
                Bitmap originalImage = new Bitmap(selectedFileName);
                pbStartImage.Image = originalImage;
            }

        }

        private void Resize_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            MessageBox.Show("You Resized the image by" + text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
