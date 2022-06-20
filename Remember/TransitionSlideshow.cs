using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remember
{
    public partial class TransitionSlideshow : Form
    {
        private static List<string> ImagesOnSlideShow { get; set; } = new List<string>();

        public TransitionSlideshow()
        {
            ImagesOnSlideShow = Dashboard.CurrentImageList;
            InitializeComponent();
            ShowSlideshow(0, 1);
        }

        public void ShowSlideshow(double opacity, int index)
        {
            Show();
            pictureBox1.Image = Image.FromFile(ImagesOnSlideShow[index].ToString());
            WindowState = FormWindowState.Maximized;
            Opacity = opacity;
            BringToFront();
        }
    }
}
