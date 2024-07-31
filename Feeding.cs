using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using ZooMayhem.Properties;

namespace ZooMayhem
{
    public partial class Feeding : Form
    {
        private Main mainForm;
        private List<Animal> zooAnimals;
        private int currentAnimalIndex = 0;
        private Image[] animalImages;

        public Feeding(Main mainForm, List<Animal> animals)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            zooAnimals = animals;

            animalImages = new Image[]
            {
                Resources.otter,
                Resources.giraffe,
                Resources.flamingo,
                Resources.lion
            };

            UpdateAnimalInfo();
            UpdateFoodCounters(); 
        }

        private void UpdateFoodCounters()
        {
            veganFoodCounter.Text = $"Vegan: {Logic.TotalQuantityOfVeganFood}";
            meatFoodCounter.Text = $"Meat: {Logic.TotalQuantityOfMeat}";
        }

        private void Feeding_Shown(object sender, EventArgs e)
        {
            UpdateFoodCounters(); 
        }

        private void UpdateAnimalInfo()
        {
            if (zooAnimals.Count > 0 && currentAnimalIndex >= 0 && currentAnimalIndex < zooAnimals.Count)
            {
                ResultLabel.Text = "";
                Animal currentAnimal = zooAnimals[currentAnimalIndex];
                animalNameLabel.Text = currentAnimal.TypeOfAnimal;
                foodTypeLabel.Text = $"Food type: {currentAnimal.GetPreferredFoodType()}";
                quantityLabel.Text = $"Quantity: {currentAnimal.Quantity}";

                ResultLabel.Text = currentAnimal.GetDaysWithoutFood();
                feedingYes.Enabled = true;
                skipButton.Enabled = true;
                sealNo.Hide();
                sealYes.Hide();

                SetAnimalImage();
            }
        }

        private void SetAnimalImage()
        {
            animalPic.Image = animalImages[currentAnimalIndex];
            animalPic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void feedingYesButton_Click(object sender, EventArgs e)
        {
            Animal currentAnimal = zooAnimals[currentAnimalIndex];
            if (currentAnimal.IsFed == true)
            {
                MessageBox.Show("This animal is already fed");
            }
            else
            {
                string feedResult = currentAnimal.Feed();
                ResultLabel.Text = feedResult;
                UpdateFoodCounters(); 
                currentAnimal.DecisionMade = true;
                currentAnimal.IsFed = true;
                feedingYes.Enabled = false;
                skipButton.Enabled = false;

                sealYes.Show();
            }
        }

        private void feedingNoButton_Click(object sender, EventArgs e)
        {
            if (zooAnimals.Count > 0 && currentAnimalIndex >= 0 && currentAnimalIndex < zooAnimals.Count)
            {
                Animal currentAnimal = zooAnimals[currentAnimalIndex];
                currentAnimal.DecreaseDaysWithoutFood();
                ResultLabel.Text = $"You decided that {currentAnimal.TypeOfAnimal} don't really want to eat.";
                currentAnimal.DecisionMade = true;
                feedingYes.Enabled = false;
                skipButton.Enabled = false;
                sealNo.Show();
            }
        }

        private void NextAnimal()
        {
            if (zooAnimals.Count > 0)
            {
                currentAnimalIndex = (currentAnimalIndex + 1) % zooAnimals.Count;
                UpdateAnimalInfo();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void nextAnimalButton_Click(object sender, EventArgs e)
        {
            Animal currentAnimal = zooAnimals[currentAnimalIndex];
            if (currentAnimal.DecisionMade)
            {
                NextAnimal();
                UpdateAnimalInfo();
                if (AreAllAnimalsDecided())
                {
                    this.Hide();
                    mainForm.Show();
                    MessageBox.Show("You're done with the daily feedings. Now you can finish the day");
                }
            }
            else
            {
                MessageBox.Show("Please make decision about feeding");
            }
        }

        private void finishDayButton_Click(object sender, EventArgs e)
        {
            if (AreAllAnimalsDecided())
            {
                MessageBox.Show("You have made decisions for all animals. You can finish the day.");
                mainForm.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("You haven't made decisions for all animals. Please make decisions before finishing the day.");
            }
        }

        private bool AreAllAnimalsDecided()
        {
            return zooAnimals.All(animal => animal.DecisionMade);
        }
    }
}
