using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();         
            
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // or FormBorderStyle.FixedSingle for a thin border
            this.MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve user input
            string fullName = textBox1.Text;
            DateTime birthdate = dateTimePicker1.Value.Date;
            int age = (int)numericUpDown1.Value;
            string address = textBox2.Text;
            string about = richTextBox1.Text;

            // Display user information
            string userInfo = $"Full Name: {fullName}\nBirthdate: {birthdate.ToShortDateString()}\nAge: {age}\nAddress: {address}\nAbout: {about}";
            MessageBox.Show(userInfo, "User Information");

            // Show confirmation message
            MessageBox.Show("Submitted", "Confirmation");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Calculate age based on the selected birthdate
            DateTime birthdate = dateTimePicker1.Value;
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthdate.Year;

            // Check if the birthday hasn't occurred yet this year
            if (birthdate.Date > currentDate.AddYears(-age))
                age--;

            // Update the numeric up-down control with the calculated age
            numericUpDown1.Value = Math.Max(18, Math.Min(100, age)); // Ensure age is between 18 and 100
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Limit the age to be between 18 and 100
            if (numericUpDown1.Value < 18)
                numericUpDown1.Value = 18;
            else if (numericUpDown1.Value > 100)
                numericUpDown1.Value = 100;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
