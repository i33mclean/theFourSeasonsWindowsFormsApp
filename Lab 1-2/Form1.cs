// Programmer: Ian McLean
// Project: Lab 1-2
// Date: 1/22/2021
//Description: The four seasons application
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Displays the Fall image
        private void fallButton_Click(object sender, EventArgs e)
        {
            seasonsPictureBox.Image = Lab_1_2.Properties.Resources.Fall;
        }
        // Displays the Winter image
        private void winterButton_Click(object sender, EventArgs e)
        {
            seasonsPictureBox.Image = Lab_1_2.Properties.Resources.Winter;
        }
        // Displays the Spring image
        private void springButton_Click(object sender, EventArgs e)
        {
            seasonsPictureBox.Image = Lab_1_2.Properties.Resources.Spring;
        }
        //Displays the Summer image
        private void summerButton_Click(object sender, EventArgs e)
        {
            seasonsPictureBox.Image = Lab_1_2.Properties.Resources.Summer;
        }
        // Closes the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
