using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Remember
{
    public partial class Slideshow : Form
    {
        private static List<string> ImagesOnSlideShow { get; set; } = new List<string>();
        private static int DisplayedImageIndex { get; set; } = 0;
        private static double OpacityRate { get; set; } = 0.05;
        private static bool IsTransitionPaused { get; set; } = false;
        private static TransitionSlideshow transitionSlideshow { get; set; } = new TransitionSlideshow();
        private static Background background { get; set; } = new Background();

        public Slideshow()
        {
            InitializeComponent();
            StartSlideshow();
        }

        private void StartSlideshow()
        {
            ImagesOnSlideShow = Dashboard.CurrentImageList;
            DisplayedImageIndex = 0;

            background.Show();

            pictureBox1.Image = Image.FromFile(Dashboard.PathToImages + ImagesOnSlideShow[DisplayedImageIndex].ToString());
            BringToFront();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (DisplayedImageIndex == ImagesOnSlideShow.Count) // aici trebuie rezolvat
            {
                pictureBox1.Image = null;
                transitionSlideshow.pictureBox1.Image = null;
                timer1.Stop();
            }
            else
            {
                // while transitioning between photos
                if (Opacity != 0 && transitionSlideshow.Opacity != 1)
                {
                    transitionSlideshow.Opacity = Math.Round(transitionSlideshow.Opacity + OpacityRate, 4);
                    Opacity = Math.Round(Opacity - OpacityRate, 4);
                }
                else
                {
                    timer1.Stop();
                    DisplayedImageIndex++;
                    pictureBox1.Image = Image.FromFile(Dashboard.PathToImages + ImagesOnSlideShow[DisplayedImageIndex]);
                }
            }
        }

        private void Slideshow_KeyDown(object sender, KeyEventArgs e)
        {
            //displayedimageindex va trebuie sa creasca sau sa scada aici in if branch uri, in functie de sensul in care se merge

            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                transitionSlideshow.Hide();
                background.Hide();

                if(Dashboard.Player != null)
                {
                    Dashboard.Player.Stop();
                }
            }
            else if (e.KeyCode == Keys.D1)
            {
                ChangeOpacityRate(0.1);
            }
            else if (e.KeyCode == Keys.D2)
            {
                ChangeOpacityRate(0.05);
            }
            else if (e.KeyCode == Keys.D3)
            {
                ChangeOpacityRate(0.025);
            }
            else if (e.KeyCode == Keys.D4)
            {
                ChangeOpacityRate(0.0167);
            }
            else if (e.KeyCode == Keys.D5)
            {
                ChangeOpacityRate(0.0125);
            }            
            if (e.KeyCode == Keys.D6)
            {
                ChangeOpacityRate(0.01);
            }
            else if (e.KeyCode == Keys.D7)
            {
                ChangeOpacityRate(0.0083);
            }
            if (e.KeyCode == Keys.D8)
            {
                ChangeOpacityRate(0.0071);
            }
            else if (e.KeyCode == Keys.D9)
            {
                ChangeOpacityRate(0.0063);
            }
            if (e.KeyCode == Keys.D0)
            {
                ChangeOpacityRate(1);
            }
            // Start/stop music
            else if (e.KeyCode == Keys.A)
            {
                // music start/stop
            }
            // pause transition
            else if (e.KeyCode == Keys.Space)
            {
                if (IsTransitionPaused)
                {
                    timer1.Start();
                    IsTransitionPaused = false;
                }
                else
                {
                    timer1.Stop();
                    IsTransitionPaused = true;

                }
            }
        }

        private void ChangeOpacityRate(double opacityRate)
        {
            Opacity = 1;
            transitionSlideshow.ShowSlideshow(0, DisplayedImageIndex + 1);
            BringToFront();
            OpacityRate = opacityRate;
            timer1.Start();
        }
    }
}