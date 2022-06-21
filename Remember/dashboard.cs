using Squirrel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remember
{
    public partial class Dashboard : Form
    {
        public static List<string> CurrentImageList { get; set; } = new List<string>();
        private int LastDeletedIndex { get; set; }
        public static SoundPlayer Player { get; set; }
        public static string Melody { get; set; }
        private static Slideshow Slideshow { get; set; }

        public Dashboard()
        {
            InitializeComponent();
            AddVersionNumber();
            CheckForUpdates();
        }

        private async Task CheckForUpdates()
        {
            using (var manager = new UpdateManager(@"D:\RememberAppReleases"))
            {
                await manager.UpdateApp();
            }
        }

        private void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            Text += $"  v.{fileVersionInfo.FileVersion}";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.deleteBtn, "Deletes the selected photo");
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Title = "Select images";
            ofDialog.Multiselect = true;
            ofDialog.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            ofDialog.InitialDirectory = @"C:";

            DialogResult dr = ofDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                List<string> fileNames = new List<string>();
                foreach (string fileName in ofDialog.FileNames)
                {
                    fileNames.Add(fileName);
                }

                bool first = true;
                string imageToBeShown = fileNames[0];

                // Union 
                foreach (string item in fileNames)
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

                pictureBox.Image = Image.FromFile(imageToBeShown);
                listBox.SelectedIndex = GgetImageIndex(imageToBeShown, listBox);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            CurrentImageList.Clear();
            pictureBox.Image = null;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            LastDeletedIndex = listBox.SelectedIndex;
            string selectedPhoto = (string)listBox.SelectedItem;
            listBox.Items.Remove(selectedPhoto);
            CurrentImageList.Remove(selectedPhoto);
        }

        private void CreateSL_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 4)
            {
                Slideshow = new Slideshow();
                Slideshow.Show();
            }
            else
            {
                MessageBox.Show("You need to upload more photos to create a slideshow", "Slideshow cannot be created!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;

            //when a new image is selected
            if (listBox.SelectedItem != null)
            {
                string selectedItem = listBox.SelectedItem.ToString();

                pictureBox.Image = Image.FromFile(selectedItem);
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
                pictureBox.Image = Image.FromFile(imageToBeShown);
                listBox.SelectedIndex = newSelectedIndex;
            }
        }

        private int GgetImageIndex(string image, ListBox listBox)
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

        private void MusicBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = @"C:";
            openFileDialog.Title = "Select music";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                musicLbl.Text = openFileDialog.FileName.Split('\\').ToList().Last();
                Melody = musicLbl.Text;
                Player = new SoundPlayer(openFileDialog.FileName);
            }
        }

        private void CloseMusicBtn_Click(object sender, EventArgs e)
        {
            Dashboard.Melody = null;
            musicLbl.Text = null;
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Slideshow != null && Slideshow.TransitionSlideshow != null)
            {
                Slideshow.TransitionSlideshow.Close();
                Slideshow.Close();
            }
        }
    }
}