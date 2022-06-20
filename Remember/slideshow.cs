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
        private static TransitionSlideshow TransitionSlideshow { get; set; } = new TransitionSlideshow();
        private static Background Background { get; set; } = new Background();
        private static Sens TransitionSens { get; set; } = Sens.Right;

        public Slideshow()
        {
            InitializeComponent();
            StartSlideshow();
        }

        private void StartSlideshow()
        {
            ImagesOnSlideShow = Dashboard.CurrentImageList;
            DisplayedImageIndex = 0;

            Background.Show();

            pictureBox1.Image = Image.FromFile(Dashboard.PathToImages + ImagesOnSlideShow[DisplayedImageIndex].ToString());
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
            else
            {
                Transitioning = false;
                timer1.Stop();

                if (TransitionSens == Sens.Right)
                {
                    DisplayedImageIndex++;
                }
                else
                {
                    DisplayedImageIndex--;
                }

                pictureBox1.Image = Image.FromFile(Dashboard.PathToImages + ImagesOnSlideShow[DisplayedImageIndex]);
            }
        }

        private void Slideshow_KeyDown(object sender, KeyEventArgs e)
        {
            //displayedimageindex va trebuie sa creasca sau sa scada aici in if branch uri, in functie de sensul in care se merge

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
                Background.Hide();

                if (Dashboard.Player != null)
                {
                    Dashboard.Player.Stop();
                }
            }
            else if (e.KeyCode == Keys.A) // Start/stop music
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
                TransitionSens = Sens.Right;
            }
            else if (e.KeyCode == Keys.Left)
            {
                TransitionSens = Sens.Left;
            }
        }

        private void ChangeOpacityRate(double opacityRate)
        {
            Opacity = 1;

            if ((TransitionSens == Sens.Right && DisplayedImageIndex == ImagesOnSlideShow.Count() - 1) || (TransitionSens == Sens.Left && DisplayedImageIndex == 0))
            {
                return;
            }
            else
            {
                Transitioning = true;

                if (TransitionSens == Sens.Right)
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





    // fac cumva cu doua variabile globale : SlideshowDisplayedImageIndex si TransitionSlideshowDisplayedImageIndex.
    // SDII va ramane la fel cand se schimba sensul, doar TSDII va fi + sau - 1.

    // Pun o poza neagra la inceput si la sfarsit? 
    // TREBUIE TRATATA EXCEPTIA ASTA

    // trebuie tratata exceptia care se arunca cand nu selectez nicio melodie.





    enum Sens { Left, Right }

}