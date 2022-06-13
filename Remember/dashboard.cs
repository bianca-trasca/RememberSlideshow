using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Remember
{
    public partial class dashboard : Form
    {
        private static string SOURCE { get; } = @"C:\Users\byanc\OneDrive - Universitatea Politehnica Timisoara\Facultate\Licenta\Repos\RememberPhotoVideoSlideshow\";
        public static string PathToImages { get; } = SOURCE + "images" + "\\";
        public static string PathToMusic { get; } = SOURCE + "music" + "\\";
        public static string PathToSlideshows { get; set; } = SOURCE + "slideshows" + "\\";

        public static List<string> CurrentImageList { get; set; } = new List<string>();
        private int LastDeletedIndex { get; set; }
        public static SoundPlayer Player { get; set; }
        public static string Melody { get; set; }

        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.deleteBtn, "Deletes the selected photo");
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Title = "Select images";
            ofDialog.Multiselect = true;
            ofDialog.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            ofDialog.InitialDirectory = PathToImages;

            DialogResult dr = ofDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                List<string> shortFileNames = new List<string>();
                foreach (string longName in ofDialog.FileNames)
                {
                    string shortName = longName.Split('\\').ToList().Last();
                    shortFileNames.Add(shortName);
                }

                bool first = true;
                string imageToBeShown = shortFileNames[0];

                // Union 
                foreach (string item in shortFileNames)
                {
                    if (!CurrentImageList.Contains(item))
                    {
                        if (first)
                        {
                            imageToBeShown = item;
                            first = false;
                        }

                        CurrentImageList.Add(item);
                        listBox.Items.Add(item);
                    }
                }

                string pathToImageToBeShown = PathToImages + imageToBeShown;
                pictureBox.Image = Image.FromFile(pathToImageToBeShown);
                listBox.SelectedIndex = getImageIndex(imageToBeShown, listBox);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            CurrentImageList.Clear();
            pictureBox.Image = null;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            LastDeletedIndex = listBox.SelectedIndex;
            string selectedPhoto = (string)listBox.SelectedItem;
            listBox.Items.Remove(selectedPhoto);
            CurrentImageList.Remove(selectedPhoto);
        }

        private void createSL_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 4)
            {
                if(Player != null)
                {
                    Player.Play();
                }
                
                new slideshow().Show();
            }
            else
            {
                MessageBox.Show("You need to upload more photos to create a slideshow", "Slideshow cannot be created!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;

            //when a new image is selected
            if (listBox.SelectedItem != null)
            {
                string selectedItem = listBox.SelectedItem.ToString();

                string pathToSelectedImage = PathToImages + selectedItem;

                pictureBox.Image = Image.FromFile(pathToSelectedImage);
            }
            //when the image selected is deleted
            else
            {
                int newSelectedIndex;

                if (listBox.Items.Count == 0)
                {
                    pictureBox.Image = null;
                    return;
                }
                //if the deleted image is not the last one
                else if (LastDeletedIndex + 1 <= listBox.Items.Count) 
                {
                    newSelectedIndex = LastDeletedIndex;
                }
                else
                {
                    newSelectedIndex = LastDeletedIndex - 1;
                }

                string imageToBeShown = listBox.Items[newSelectedIndex].ToString();
                string pathToImageToBeShown = PathToImages + imageToBeShown;
                pictureBox.Image = Image.FromFile(pathToImageToBeShown);
                listBox.SelectedIndex = newSelectedIndex;
            }
        }

        private int getImageIndex(string image, ListBox listBox)
        {
            for (int index = 0; index <= listBox.Items.Count; index++)
            {
                if (listBox.Items[index].ToString().Equals(image))
                {
                    return index;
                }
            }
            return 0;
        }

        private void musicBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = @"C:\Users\byanc\OneDrive - Universitatea Politehnica Timisoara\Facultate\Licenta\Repos\RememberPhotoVideoSlideshow\music";
            openFileDialog.Title = "Select music";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                musicLbl.Text = openFileDialog.FileName.Split('\\').ToList().Last();
                Melody = musicLbl.Text;
                Player = new SoundPlayer(openFileDialog.FileName);
            }
        }

        private void openSlideshowBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                CreateSlideshowFromText(ofd.FileName);
            }
        }

        private void CreateSlideshowFromText(string pathToText)
        {
            Dictionary<string, int> imagesAndTime = new Dictionary<string, int>();
            string melody;

            StreamReader sr = new StreamReader(pathToText);
            string text = sr.ReadToEnd();

            string[] values = text.Split(' ');

            melody = values[0];

            for (int i = 1; i < values.Length; i = i + 2)
            {
                imagesAndTime.Add(values[i], Convert.ToInt32(values[i + 1]));
            }

            new slideshow(imagesAndTime, melody).Show();
        }

        private void closeMusicBtn_Click(object sender, EventArgs e)
        {
            dashboard.Melody = null;
            musicLbl.Text = null;
        }
    }
}