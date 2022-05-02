using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remember
{
    public partial class dashboard : Form
    {
        List<string> longNameList = new List<string>();

        public dashboard()
        {
            InitializeComponent();
        }

        Image file;
        Boolean opened = false;


        //public void OpenImage()
        //{
        //    DialogResult dialog = openFileDialog1.ShowDialog();
        //    if(dialog == DialogResult.OK)
        //    {
        //        file = Image.FromFile(openFileDialog1.FileName);
        //        pictureBox.Image = file;
        //        opened = true;
        //    }
        //}

        public void SaveImage()
        {
            if(opened)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;

                if(saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(saveFileDialog.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    //pictureBox.Image.Save(saveFileDialog.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Please upload an image first!");
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenImages();
        }

        private void createSL_Click(object sender, EventArgs e)
        {
            //SaveImage();
            // Create SLideShow
        }
        
        // https://www.youtube.com/watch?v=d0AHKq7lDF4
        private void OpenImages()
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Title = "Select images";
            ofDialog.Multiselect = true;
            ofDialog.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            DialogResult dr = ofDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Union(longNameList, ofDialog.FileNames);

                ListBox listBox = new ListBox();
                listBox.Location = new Point(3, 3);
                listBox.Width = 253;
                listBox.Height = 490;
                listBox.BorderStyle = BorderStyle.None;
                //listBox.BackColor = Color.Gray;
                listBox.Name = "Image List";

                List<string> shortNameList = new List<string> ();

                foreach (string longName in longNameList)
                {
                    shortNameList = longName.Split('\\').ToList();
                    listBox.Items.Add(shortNameList.Last());
                }

                this.listBox.Controls.Clear();
                this.listBox.Controls.Add(listBox);
            }
        }

        //private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    if (treeView1.SelectedNode.Text == "Usercontrol1")
        //    {trdtygregfdgvfdgfdsijmonabiiibiancabiancaasdfghjkllkjhgfds
        //        panel.Controls.Clear();
        //        panel.Visible = true;
        //        UserControl1 usr1 = new UserControl1();
        //        usr1.Show();
        //        panel1.Controls.Add(usr1);
        //    }
        //    if (treeView1.SelectedNode.Text == "Usercontrol2")
        //    {
        //        panel.Controls.Clear();
        //        panel.Visible = true;
        //        UserControl2 usr2 = new UserControl2();
        //        usr2.Show();
        //        panel1.Controls.Add(usr2);
        //    }
        //    if (treeView1.SelectedNode.Text == "Root")
        //    {
        //        panel.Controls.Clear();
        //        panel.Visible = false;
        //    }
        //}

        // copies items from set2 into set1 if they are not already there
        
        static void Union(List<string> set1, string[] set2)
        {
            foreach (string item in set2)
            {
                if (!set1.Contains(item))
                {
                    set1.Add(item);
                }
            }
        }
    }
}
