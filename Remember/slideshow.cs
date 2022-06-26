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
        private static bool Transitioning { get; set; } = false;
        private static bool IsMusicPaused { get; set; } = true;
        public static TransitionSlideshow TransitionSlideshow { get; set; } = new TransitionSlideshow();
        private static Background Background { get; set; }
        private static Direction TransitionDirection { get; set; } = Direction.Right;


        public Slideshow()
        {
            InitializeComponent();
            StartSlideshow();
        }

        private void StartSlideshow()
        {
            ImagesOnSlideShow = Dashboard.CurrentImageList;
            DisplayedImageIndex = 0;
            TransitionDirection = Direction.Right;

            Background = new Background();
            Background.Show();

            pictureBox1.Image = Image.FromFile(ImagesOnSlideShow[DisplayedImageIndex].ToString());
            BringToFront();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // while transitioning between photos
            if (Opacity != 0 && TransitionSlideshow.Opacity != 1)
            {
                TransitionSlideshow.Opacity = Math.Round(TransitionSlideshow.Opacity + OpacityRate, 4);
                Opacity = Math.Round(Opacity - OpacityRate, 4);
                return;
            }
            else // when transition is complete
            {
                Transitioning = false;
                timer1.Stop();

                if (TransitionDirection == Direction.Right)
                {
                    DisplayedImageIndex++;
                }
                else if(TransitionDirection == Direction.Left)
                {
                    DisplayedImageIndex--;
                }

                pictureBox1.Image = Image.FromFile(ImagesOnSlideShow[DisplayedImageIndex]);
            }
        }

        private void Slideshow_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Transitioning)
            {
                if (e.KeyCode == Keys.D1)
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
                else if (e.KeyCode == Keys.D6)
                {
                    ChangeOpacityRate(0.01);
                }
                else if (e.KeyCode == Keys.D7)
                {
                    ChangeOpacityRate(0.0083);
                }
                else if (e.KeyCode == Keys.D8)
                {
                    ChangeOpacityRate(0.0071);
                }
                else if (e.KeyCode == Keys.D9)
                {
                    ChangeOpacityRate(0.0063);
                }
                else if (e.KeyCode == Keys.D0)
                {
                    ChangeOpacityRate(1);
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                TransitionSlideshow.Hide();
                Background.Close();

                if (Dashboard.Player != null)
                {
                    Dashboard.Player.Stop();
                }
            }
            else if (e.KeyCode == Keys.A) // Start/stop music
            {
                if (Dashboard.Player != null)
                {
                    if (IsMusicPaused)
                    {
                        Dashboard.Player.Play();
                        IsMusicPaused = false;
                    }
                    else
                    {
                        Dashboard.Player.Stop();
                        IsMusicPaused = true;
                    }
                }
            }
            else if (e.KeyCode == Keys.Space) // pause transition
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
            else if (e.KeyCode == Keys.Right)
            {
                TransitionDirection = Direction.Right;
            }
            else if (e.KeyCode == Keys.Left)
            {
                TransitionDirection = Direction.Left;
            }
        }

        private void ChangeOpacityRate(double opacityRate)
        {
            Opacity = 1;

            if ((TransitionDirection == Direction.Right && DisplayedImageIndex == ImagesOnSlideShow.Count() - 1)
                || (TransitionDirection == Direction.Left && DisplayedImageIndex == 0))
            {
                return;
            }
            else
            {
                Transitioning = true;

                if (TransitionDirection == Direction.Right)
                {
                    TransitionSlideshow.ShowSlideshow(0, DisplayedImageIndex + 1);
                }
                else
                {
                    TransitionSlideshow.ShowSlideshow(0, DisplayedImageIndex - 1);
                }
                BringToFront();
                OpacityRate = opacityRate;
                timer1.Start();
            }
        }
    }


    enum Direction { Left, Right }

}