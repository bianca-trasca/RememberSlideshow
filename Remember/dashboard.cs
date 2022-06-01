using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WMPLib;

namespace Remember
{
    public partial class dashboard : Form
    {
        public static List<string> currentImageList { get; set; } = new List<string>();
        private string pathToImages { get; } = @"C:\Users\byanc\OneDrive - Universitatea Politehnica Timisoara\Facultate\Licenta\Repos\RememberPhotoVideoSlideshow\images\";
        private string pathToMusic { get; } = @"C:\Users\byanc\OneDrive - Universitatea Politehnica Timisoara\Facultate\Licenta\Repos\RememberPhotoVideoSlideshow\music\";
        private int lastDeletedIndex;
        public static SoundPlayer player;
        public static string melody;

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
            ofDialog.InitialDirectory = @"C:\Users\byanc\OneDrive - Universitatea Politehnica Timisoara\Facultate\Licenta\Repos\RememberPhotoVideoSlideshow\images";

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
                    if (!currentImageList.Contains(item))
                    {
                        if (first)
                        {
                            imageToBeShown = item;
                            first = false;
                        }

                        currentImageList.Add(item);
                        listBox.Items.Add(item);
                    }
                }

                string pathToImageToBeShown = pathToImages + imageToBeShown;
                pictureBox.Image = Image.FromFile(pathToImageToBeShown);
                listBox.SelectedIndex = getImageIndex(imageToBeShown, listBox);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            currentImageList.Clear();
            pictureBox.Image = null;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            lastDeletedIndex = listBox.SelectedIndex;
            string selectedPhoto = (string)listBox.SelectedItem;
            listBox.Items.Remove(selectedPhoto);
            currentImageList.Remove(selectedPhoto);
        }

        private void createSL_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 4)
            {
                player.Play();
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

                string pathToSelectedImage = String.Format(@"C:\Users\byanc\OneDrive - Universitatea Politehnica Timisoara\Facultate\Licenta\Repos\RememberPhotoVideoSlideshow\images\{0}", selectedItem);

                pictureBox.Image = Image.FromFile(pathToSelectedImage);
            }
            else //when the image selected is deleted
            {
                int newSelectedIndex;

                if (listBox.Items.Count == 0)
                {
                    pictureBox.Image = null;
                    return;
                }
                else if (lastDeletedIndex + 1 <= listBox.Items.Count) //if the deleted image is not the last one
                {
                    newSelectedIndex = lastDeletedIndex;
                }
                else
                {
                    newSelectedIndex = lastDeletedIndex - 1;
                }

                string imageToBeShown = listBox.Items[newSelectedIndex].ToString();
                string pathToImageToBeShown = pathToImages + imageToBeShown;
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
                melody = musicLbl.Text;
                player = new SoundPlayer(openFileDialog.FileName);

            }
        }
    }
}
