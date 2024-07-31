using System.Windows.Forms;
using System;

namespace ZooMayhem
{
    public partial class Rules : Form
    {
        private Main mainForm;

        public Rules(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
