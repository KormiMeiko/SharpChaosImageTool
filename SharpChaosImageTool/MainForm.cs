namespace SharpChaosImageTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog S = new OpenFileDialog())
            {
                S.DefaultExt = "";
                S.Filter = "Image files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
                S.InitialDirectory = "";
                if (S.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picSource.Image = Image.FromFile(S.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error has occurred. The content is as follows:\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double u, x0;
                double.TryParse(uTextBox.Text, out u);
                double.TryParse(xTextBox.Text, out x0);

                if (u < 3.57 || u > 4)
                {
                    MessageBox.Show("The parameter u should be greater than or equal to 3.57 and less than or equal to 4.", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (x0 <= 0 || x0 >= 1)
                {
                    MessageBox.Show("The parameter x should be greater than 0 and less than 1.", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (picSource.Image is not Bitmap src)
                {
                    MessageBox.Show("Please load the image to be processed before proceeding.", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                picDest.Image = Chaos.Encrypt(src, u, x0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. The content is as follows:\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.picDest.Image is not Bitmap dest)
            {
                MessageBox.Show("You haven't done image processing yet, please process an image before proceeding.", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog S = new SaveFileDialog())
            {
                S.DefaultExt = "png";
                S.Filter = "Image files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
                S.InitialDirectory = "";
                S.FileName = "";
                if (S.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        dest.Save(S.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error has occurred. The content is as follows:\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
