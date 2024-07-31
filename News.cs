using System.Windows.Forms;
using System;

namespace ZooMayhem
{
    public partial class News : Form
    {
        private Main mainForm;
        public string Title { get; private set; }
        public string Content { get; private set; }

        public News(Main mainForm, string content)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            Title = "Breaking news!";
            Content = content;
            UpdateNewsDisplay();
        }

        private void UpdateNewsDisplay()
        {
            NewsLabel.Text = $"{Title}\n\n{Content}";
        }

        public static News GenerateRandomNews(Main mainForm)
        {
            var randomNewsObject = NewsGenerator.GenerateRandomNewsObject(mainForm);
            return new News(mainForm, randomNewsObject.Content);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var randomNews = NewsGenerator.GenerateRandomNewsObject(mainForm);
            Title = randomNews.Title;
            Content = randomNews.Content;
            UpdateNewsDisplay();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }
    }
}
