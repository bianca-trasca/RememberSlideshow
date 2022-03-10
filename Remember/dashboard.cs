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
        public dashboard()
        {
            InitializeComponent();
        }

        Image file;
        Boolean opened = false;


        public void openImage()
        {
            DialogResult dialog = openFileDialog1.ShowDialog();
            if(dialog == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened = true;
            }
        }

        public void saveImage()
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
                    pictureBox1.Image.Save(saveFileDialog.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Please upload an image first!");
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            openImage();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveImage();
        }
    }
}
