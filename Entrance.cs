using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooMayhem
{
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
            
        }
        private void InitializeFullScreen()
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("serafimspetrovs@gmail.com");

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            startButton.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
