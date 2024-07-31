using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZooMayhem
{
    public partial class Cashier : Form
    {
        private Main mainForm;

        public Cashier(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            InitializeCustomComponents();
            Logic.DayChanged += OnDayChanged;
            moneyLabel.Text = $"{Logic.Money}";
        }

        private void OnDayChanged(object sender, EventArgs e)
        {
            InitializeCustomComponents();
            UpdateIncomeLabels();
        }

        private void InitializeCustomComponents()
        {
            earningChart.Series["Earn"].Points.Clear();
            earningChart.Series["Expenses"].Points.Clear();
            earningChart.Series["Clean income"].Points.Clear();
            hireCafeButton.Text = Logic.CafeHireStatus ? "Fire" : "Hire";
            hireShopButton.Text = Logic.ShopHireStatus ? "Fire" : "Hire";
            HireCleanerButton.Text = Logic.CleanerHireStatus ? "Fire" : "Hire";




            for (int i = 0; i < Logic.Day; i++)
            {
                if (i < Logic.DailyEarnings.Count)
                    earningChart.Series["Earn"].Points.AddXY($"Day {i + 1}", Logic.DailyEarnings[i]);
                if (i < Logic.DailyExpenses.Count)
                    earningChart.Series["Expenses"].Points.AddXY($"Day {i + 1}", Logic.DailyExpenses[i]);
                if (i < Logic.DailyClean.Count)
                    earningChart.Series["Clean income"].Points.AddXY($"Day {i + 1}", Logic.DailyClean[i]);
            }
        }

        private void UpdateIncomeLabels()
        {
            allInfoLabel.Font = new Font(allInfoLabel.Font.FontFamily, 22);
            allInfoLabel.Text = $"Income from ticket sales: {Logic.Ticket}\n" +
                                $"Income from cafe: {Logic.Cafe}\n" +
                                $"Income from souvenir shop: {Logic.Shop}\n" +
                                $"Income from barker: {Logic.Cleaner}\n" +
                                $"Dirty income: {Logic.DirtyIncome}  Clean income: {Logic.CleanIncome}\n" +
                                $"Expenses: {Logic.Expenses}";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void showChartsButton_Click(object sender, EventArgs e)
        {
            earningChart.Visible = !earningChart.Visible;

            allInfoLabel.Visible = false;
            hireShopButton.Visible = false;
            hireCafeButton.Visible = false;
            HireCleanerButton.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void showIncomesButton_Click(object sender, EventArgs e)
        {
            allInfoLabel.Visible = false;
            allInfoLabel.Visible = !allInfoLabel.Visible; 

            UpdateIncomeLabels();

            earningChart.Visible = false;
            hireShopButton.Visible = false;
            hireCafeButton.Visible = false;
            HireCleanerButton.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            label3.Visible = !label3.Visible;
            label4.Visible = !label4.Visible;
            allInfoLabel.Visible = false; 
            allInfoLabel.Visible = !allInfoLabel.Visible; 
            allInfoLabel.Font = new Font(allInfoLabel.Font.FontFamily, 14);
            allInfoLabel.Text = @"
Cafe Employee
Description: Emma, our cafe wizard, can whip up a cappuccino faster than you can say 'espresso.' Known for her infectious smile and impeccable latte art, Emma ensures every visitor leaves with a full stomach and a happy heart. When she's not serving the best coffee in town, she's experimenting with new recipes, often resulting in delicious, albeit sometimes peculiar, creations.
Daily Wage: 150 units per day

Souvenir shop employee
Description: Sam is the master of mementos, turning even the most reluctant visitors into proud owners of zoo-themed souvenirs. With a knack for knowing exactly what every customer wants, Sam's sales tactics are as charming as they are effective. From plush animals to quirky t-shirts, if it exists, Sam can sell it. He's also a walking encyclopedia of fun facts about every item in the shop. Rumor has it, Sam can even sell ice to a penguin!
Daily Wage: 130 units per day

Alex...or just Barker
Description: Alex, once hopeful of navigating the digital seas as a programmer, found himself shipwrecked on the shores of zoo life faster than a buffer overflow crashes a system. Denied entry to the tech world for lack of experience, he now spends his days as a barker, enticing visitors to the zoo with elaborate pitches and existential musings. His dreams of coding glory lie buried under more layers than an overly complicated recursive function. Despite never having set foot in a coding office, Alex regales visitors not with jokes, but with poignant stories from his imagined life as a programmer. His narratives of missed opportunities, unrealized projects, and the cruel whims of tech hiring managers are a dark commentary on dashed aspirations and the harsh realities of career paths untaken. If you're craving a dose of black comedy seasoned with the bitter salt of shattered ambitions, Alex's tales are sure to evoke both laughter and a pang of sympathy.
Daily Wage: 120 units per day
";
            hireCafeButton.Visible=!hireCafeButton.Visible;
            hireShopButton.Visible = !hireShopButton.Visible;
            HireCleanerButton.Visible = !HireCleanerButton.Visible;
            

            earningChart.Visible = false;
        }

        private void hireCafeButton_Click(object sender, EventArgs e)
        {
            Logic.CafeHireStatus = !Logic.CafeHireStatus; 
            hireCafeButton.Text = Logic.CafeHireStatus ? "Fire" : "Hire"; 
        }

        private void hireShopButton_Click(object sender, EventArgs e)
        {
            Logic.ShopHireStatus = !Logic.ShopHireStatus;
            hireShopButton.Text=Logic.ShopHireStatus? "Fire" : "Hire";
        }

        private void HireCleanerButton_Click(object sender, EventArgs e)
        {
            Logic.CleanerHireStatus = !Logic.CleanerHireStatus;
            HireCleanerButton.Text = Logic.CleanerHireStatus ? "Fire" : "Hire";
        }

        private void allInfoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
