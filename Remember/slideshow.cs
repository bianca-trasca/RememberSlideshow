using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remember
{
    public partial class slideshow : Form
    {
        private static string pathToImages = @"C:\Users\byanc\OneDrive - Universitatea Politehnica Timisoara\Facultate\Licenta\Repos\RememberPhotoVideoSlideshow\images\";
        private static string pathToSlideshows = @"C:\Users\byanc\OneDrive - Universitatea Politehnica Timisoara\Facultate\Licenta\Repos\RememberPhotoVideoSlideshow\slideshows";
        private static List<string> imagesOnSlideShow = new List<string>();
        private static int displayedImageIndex = 0;
        private static string currentPhotoOnSL;
        private static Dictionary<string, int> recordedImagesAndTime { get; set; } = new Dictionary<string, int>();

        public slideshow()
        {
            InitializeComponent();
            StartSlideshow();
        }

        private void StartSlideshow()
        {
            imagesOnSlideShow = dashboard.currentImageList;
            displayedImageIndex = 0;
            timer1.Start();

            pictureBox1.Image = Image.FromFile(pathToImages + imagesOnSlideShow[0].ToString());
            RecordSlideshow();
        }

        private void slideshow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.WindowState = FormWindowState.Normal;
                this.Hide();
                dashboard.player.Stop();

                DialogResult dr = MessageBox.Show("Would you like to save the slideshow?", "Save slideshow!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    WriteRecordedDataToFile();
                }
                else
                {
                    recordedImagesAndTime.Clear();
                    dashboard.melody = null;
                }
            }
            else if (e.KeyCode == Keys.D1)
            {
                timer1.Interval = 1000;
                foreach (string image in recordedImagesAndTime.Keys)
                {
                    if (image.Equals(currentPhotoOnSL))
                    {
                        recordedImagesAndTime[image] = 1000;
                        break;
                    }
                }
            }
            else if (e.KeyCode == Keys.D2)
            {
                timer1.Interval = 2000;
                foreach (string image in recordedImagesAndTime.Keys)
                {
                    if (image.Equals(currentPhotoOnSL))
                    {
                        recordedImagesAndTime[image] = 2000;
                        break;
                    }
                }
            }
            else if (e.KeyCode == Keys.D3)
            {
                timer1.Interval = 3000;
                foreach (string image in recordedImagesAndTime.Keys)
                {
                    if (image.Equals(currentPhotoOnSL))
                    {
                        recordedImagesAndTime[image] = 3000;
                        break;
                    }
                }
            }
            else if (e.KeyCode == Keys.D4)
            {
                timer1.Interval = 4000;
                foreach (string image in recordedImagesAndTime.Keys)
                {
                    if (image.Equals(currentPhotoOnSL))
                    {
                        recordedImagesAndTime[image] = 4000;
                        break;
                    }
                }
            }
            else if (e.KeyCode == Keys.D5)
            {
                timer1.Interval = 5000;
                foreach (string image in recordedImagesAndTime.Keys)
                {
                    if (image.Equals(currentPhotoOnSL))
                    {
                        recordedImagesAndTime[image] = 5000;
                        break;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayedImageIndex++;

            if (displayedImageIndex == imagesOnSlideShow.Count)
            {
                pictureBox1.Image = null;
                timer1.Stop();
            }
            else
            {
                pictureBox1.Image = Image.FromFile(pathToImages + imagesOnSlideShow[displayedImageIndex]);
                currentPhotoOnSL = imagesOnSlideShow[displayedImageIndex];
            }
        }

        private void RecordSlideshow()
        {
            //pun toate detaliile intr-o lista si dupa ce dau esc intreb daca se doreste salvarea slideshowului. daca da, se ia pathul si atunci se scrie.
            //daca nu, se da clear la tot

            foreach (string image in imagesOnSlideShow)
            {
                recordedImagesAndTime.Add(image, 2000);
            }
        }

        private void WriteRecordedDataToFile()
        {
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Title = "Save slideshow";
            sfDialog.InitialDirectory = pathToSlideshows;

            DialogResult dr = sfDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(sfDialog.FileName);

                sr.WriteLine(dashboard.melody);

                foreach (string image in recordedImagesAndTime.Keys)
                {
                    sr.WriteLine(image + " " + recordedImagesAndTime[image]);
                }

                sr.Close();
            }
        }
    }
}
