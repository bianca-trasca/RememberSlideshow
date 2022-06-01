using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Remember
{
    public partial class slideshow : Form
    {
        private static List<string> ImagesOnSlideShow { get; set; } = new List<string>();
        private static int DisplayedImageIndex { get; set; } = 0;
        private static string CurrentPhotoOnSL { get; set; }
        private static bool OpenedSL { get; set; } = false;
        private static Dictionary<string, int> Images { get; set; }
        private static Dictionary<string, int> RecordedImagesAndTime { get; set; } = new Dictionary<string, int>();

        public slideshow()
        {
            InitializeComponent();
            StartSlideshow();
        }

        public slideshow(Dictionary<string, int> images, string melody)
        {
            InitializeComponent();
            StartOpenedSlideshow(images, melody);
        }

        private void StartSlideshow()
        {
            ImagesOnSlideShow = dashboard.CurrentImageList;
            DisplayedImageIndex = 0;
            timer1.Start();

            pictureBox1.Image = Image.FromFile(dashboard.PathToImages + ImagesOnSlideShow[0].ToString());
            RecordSlideshow();
        }

        private void StartOpenedSlideshow(Dictionary<string, int> images, string melody)
        {
            OpenedSL = true;

            if (!melody.Equals("noMusic"))
            {
                SoundPlayer player = new SoundPlayer(dashboard.PathToMusic + melody.Replace("_", " "));
                dashboard.Player = player;
                dashboard.Player.Play();
                dashboard.Melody = melody;
            }

            Images = images;
            ImagesOnSlideShow = images.Keys.ToList();
            DisplayedImageIndex = 0;
            timer2.Interval = images.Values.First();
            timer2.Start();
            pictureBox1.Image = Image.FromFile(dashboard.PathToImages + ImagesOnSlideShow[0].ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayedImageIndex++;

            if (DisplayedImageIndex == ImagesOnSlideShow.Count)
            {
                pictureBox1.Image = null;
                timer1.Stop();
            }
            else
            {
                pictureBox1.Image = Image.FromFile(dashboard.PathToImages + ImagesOnSlideShow[DisplayedImageIndex]);
                CurrentPhotoOnSL = ImagesOnSlideShow[DisplayedImageIndex];
                RecordedImagesAndTime[CurrentPhotoOnSL] = timer1.Interval;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DisplayedImageIndex++;

            if (DisplayedImageIndex == ImagesOnSlideShow.Count)
            {
                pictureBox1.Image = null;
                timer2.Stop();
            }
            else
            {
                pictureBox1.Image = Image.FromFile(dashboard.PathToImages + ImagesOnSlideShow[DisplayedImageIndex]);
                CurrentPhotoOnSL = ImagesOnSlideShow[DisplayedImageIndex];
                timer2.Interval = Images[CurrentPhotoOnSL];
            }
        }

        private void slideshow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.WindowState = FormWindowState.Normal;
                this.Hide();
                if(dashboard.Player != null)
                {
                    dashboard.Player.Stop();
                }
                
                if (!OpenedSL)
                {
                    DialogResult dr = MessageBox.Show("Would you like to save the slideshow?", "Save slideshow!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        WriteRecordedDataToFile();
                    }

                    RecordedImagesAndTime.Clear();
                }

            }
            else if (e.KeyCode == Keys.D1)
            {
                timer1.Interval = 1000;
                foreach (string image in RecordedImagesAndTime.Keys)
                {
                    if (image.Equals(CurrentPhotoOnSL))
                    {
                        RecordedImagesAndTime[image] = 1000;
                        break;
                    }
                }
            }
            else if (e.KeyCode == Keys.D2)
            {
                timer1.Interval = 2000;
                foreach (string image in RecordedImagesAndTime.Keys)
                {
                    if (image.Equals(CurrentPhotoOnSL))
                    {
                        RecordedImagesAndTime[image] = 2000;
                        break;
                    }
                }
            }
            else if (e.KeyCode == Keys.D3)
            {
                timer1.Interval = 3000;
                foreach (string image in RecordedImagesAndTime.Keys)
                {
                    if (image.Equals(CurrentPhotoOnSL))
                    {
                        RecordedImagesAndTime[image] = 3000;
                        break;
                    }
                }
            }
            else if (e.KeyCode == Keys.D4)
            {
                timer1.Interval = 4000;
                foreach (string image in RecordedImagesAndTime.Keys)
                {
                    if (image.Equals(CurrentPhotoOnSL))
                    {
                        RecordedImagesAndTime[image] = 4000;
                        break;
                    }
                }
            }
            else if (e.KeyCode == Keys.D5)
            {
                timer1.Interval = 5000;
                foreach (string image in RecordedImagesAndTime.Keys)
                {
                    if (image.Equals(CurrentPhotoOnSL))
                    {
                        RecordedImagesAndTime[image] = 5000;
                        break;
                    }
                }
            }
        }

        private void RecordSlideshow()
        {
            foreach (string image in ImagesOnSlideShow)
            {
                RecordedImagesAndTime.Add(image, 2000);
            }
        }

        private void WriteRecordedDataToFile()
        {
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Title = "Save slideshow";
            sfDialog.InitialDirectory = dashboard.PathToSlideshows;

            DialogResult dr = sfDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(sfDialog.FileName);

                if (dashboard.Melody != null)
                {
                    sr.Write(dashboard.Melody.Replace(" ", "_"));
                }
                else
                {
                    sr.Write("noMusic");
                }
                
                foreach (string image in RecordedImagesAndTime.Keys)
                {
                    sr.Write(" " + image + " " + RecordedImagesAndTime[image]);
                }

                sr.Close();
            }
        }
    }
}