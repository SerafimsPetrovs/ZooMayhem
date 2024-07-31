using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.IO;

namespace ZooMayhem
{
    public partial class Main : Form
    {
        private List<Animal> animals;
        private Random random;
        private SoundPlayer player;
        private static string tempPath;
        private static bool isMusicPlaying = false;



        public Main()
        {
            InitializeComponent();
            InitializeAnimals();
            Logic.Initialize();
            UpdateDayLabel();
            random = new Random();


            InitializeMusicPlayer();

        }


        private void InitializeMusicPlayer()
        {
            try
            {
                Stream resourceStream = Properties.Resources.backgroundMusic;
                tempPath = Path.GetTempFileName();
                using (FileStream fs = new FileStream(tempPath, FileMode.Create))
                {
                    resourceStream.CopyTo(fs);
                }
                player = new SoundPlayer(tempPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing music player: " + ex.Message);
            }
        }



        private void musicButton_Click(object sender, EventArgs e)
        {
            if (isMusicPlaying)
            {
                player.Stop();
                isMusicPlaying = false;
                musicButton.Text = "Play Music";
                musicButton.BackColor = Color.FromArgb(54, 103, 84);
            }
            else
            {
                player.PlayLooping();
                isMusicPlaying = true;
                musicButton.Text = "Stop Music";

                musicButton.BackColor = Color.IndianRed;
            }

        }




        private void InitializeAnimals()
        {
            animals = new List<Animal>
    {
        new Otters(false, 5),
        new Giraffes(false, 3),
        new Flamingos(false, 12),
        new Lions(false, 1)
    };
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void feedingButton_Click(object sender, EventArgs e)
        {
            if (AreAllAnimalsDecided())
            {
                MessageBox.Show("All animals have already been fed for the day.");
            }
            else
            {
                Feeding feedingForm = new Feeding(this, animals);
                feedingForm.Show();
                this.Hide();
            }
        }

        private bool AreAllAnimalsDecided()
        {
            return animals.All(animal => animal.DecisionMade);
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            Rules rulesForm = new Rules(this);
            rulesForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cashier cashierForm = new Cashier(this);
            cashierForm.Show();
        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {
            if (AreAllAnimalsDecided())
            {
                this.Hide();
                EveningEvent eveningEvent = new EveningEvent(this, animals);
                eveningEvent.Show();
            }
            else
            {
                MessageBox.Show("You haven't decided whether to feed the animals today. You don't want them to start a revolution and create anarchy, do you? ");
            }
        }

        public void UpdateDayLabel()
        {
            dayLabel.Text = $"Day: {Logic.Day}";
        }

        public void ResetAnimalsFeedingStatus()
        {
            foreach (var animal in animals)
            {
                animal.DecisionMade = false;
                animal.IsFed = false;
            }
        }

        private void newsButton_Click(object sender, EventArgs e)
        {
            News newsForm = NewsGenerator.GenerateRandomNewsObject(this);
            newsForm.Show();
            this.Hide();
        }


    }
}