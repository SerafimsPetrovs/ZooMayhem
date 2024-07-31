using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZooMayhem.Properties;

namespace ZooMayhem
{
    public partial class EveningEvent : Form
    {
        private Main mainForm;
        private List<Animal> zooAnimals;
        private string currentEventType;
        private bool userChoiceMade = false;


        public EveningEvent(Main mainForm, List<Animal> zooAnimals)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.zooAnimals = zooAnimals;
            userChoiceMade = false;

            DisplayEvent();
        }

        private void DisplayEvent()
        {
            string eventResult = EventsForEvening.EventShuffle(zooAnimals, out currentEventType);

            eventTextLabel.Text = eventResult;

            bool isChoiceRequired = currentEventType == "FindFood" || currentEventType == "Trader";
            yesButton.Visible = isChoiceRequired;
            noButton.Visible = isChoiceRequired;
            if (currentEventType == "FindFood")
            {
                EventPic.BackgroundImage = Resources.foodFinding;
            }
            if (currentEventType == "Trader")
            {
                EventPic.BackgroundImage = Resources.trader;
            }
            if(currentEventType== "FoodDelivery")
            {
                EventPic.BackgroundImage = Resources.delivery;
            }
           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            HandleUserChoice(false);
            userChoiceMade=true;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            HandleUserChoice(true);
            userChoiceMade=true;
        }

        private void HandleUserChoice(bool userChoice)
        {
            string result = string.Empty;

            switch (currentEventType)
            {
                case "FindFood":
                    result = EventsForEvening.FindFoodEvent(userChoice);
                    break;
                case "Trader":
                    result = EventsForEvening.HandleTraderChoice(zooAnimals, userChoice);
                    break;
                case "NeedMedic":
                    result = EventsForEvening.NeedMedicEvent();
                    break;
                case "FoodDelivery":
                    result = EventsForEvening.FoodDelivery();
                    break;
                case "None":
                    result = "Nothing happened today.";
                    break;
                default:
                    result = "An error occurred.";
                    break;
            }

            eventTextLabel.Text = result;

            yesButton.Visible = false;
            noButton.Visible = false;
        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {
            if ((currentEventType == "FindFood" || currentEventType == "Trader") && !userChoiceMade)
            {
                MessageBox.Show("Please make a choice before proceeding to the next day.");
                return;
            }

            Logic.DayChange(zooAnimals);
            mainForm.UpdateDayLabel();
            Logic.GetAnimalsStatus(zooAnimals);
            mainForm.ResetAnimalsFeedingStatus();
            this.Hide();
            mainForm.Show();

        }
    }
}
