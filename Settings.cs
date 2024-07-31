using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace ZooMayhem
{
    public partial class Settings : Form
    {
        private static Point initialButtonLocation = Point.Empty;
        private static bool isMoved = false;
        private SoundPlayer player;
        private static bool isMusicPlaying = false;
        private static string tempPath;

        public Settings()
        {
            InitializeComponent();

            if (initialButtonLocation == Point.Empty)
            {
                initialButtonLocation = musicButton.Location;
            }

            if (!string.IsNullOrEmpty(tempPath))
            {
                player = new SoundPlayer(tempPath);
            }
            else
            {
                Stream resourceStream = Properties.Resources.backgroundMusic;

                tempPath = Path.GetTempFileName();

                using (FileStream fs = new FileStream(tempPath, FileMode.Create))
                {
                    resourceStream.CopyTo(fs);
                }

                player = new SoundPlayer(tempPath);
            }

            UpdateButtonState();

            
            if (isMusicPlaying)
            {
                player.PlayLooping();
            }
        }

        private void UpdateButtonState()
        {
            if (isMoved)
            {
                musicButton.Location = new Point(initialButtonLocation.X - 135, initialButtonLocation.Y);
                musicButton.Text = "On";
                musicBackLabel.BackColor = Color.OliveDrab;
            }
            else
            {
                musicButton.Location = initialButtonLocation;
                musicButton.Text = "Off";
                musicBackLabel.BackColor = Color.IndianRed;
            }
        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            if (isMoved)
            {
                player.Stop();
                isMusicPlaying = false;
            }
            else
            {
                player.PlayLooping(); 
                isMusicPlaying = true;
            }
            isMoved = !isMoved;
            UpdateButtonState();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void musicBackLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
