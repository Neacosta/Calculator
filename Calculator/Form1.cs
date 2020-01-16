using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Project      Calculator lab 3
    Programmer   Nelson Acosta
    Date         January 2018
                
    	         Display a calculation
*/

namespace Calculator
{
    public partial class calculatorForm : Form
    {
        public calculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.codedPictureBox.Image = Image.FromFile("calculator.png");
                // Multiplies the number 

                decimal firstNumber, secondNumber, total; // Variable declaration

                firstNumber = decimal.Parse(textBox2.Text);
                secondNumber = decimal.Parse(textBox1.Text);
                total = firstNumber * secondNumber;
                calculationLabel.Text = total.ToString(); //  Displays the total on the application
            }
            catch
            {
                //Display error message 
                MessageBox.Show("invalid data was entered");
                textBox2.Focus();
                textBox2.SelectAll();
            }
        }  

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.codedPictureBox.Image = Image.FromFile("calculator.png"); // Displays the pictures
                
                // Adds the numbers
                decimal firstNumber, secondNumber, total; // Variable declaration

                firstNumber = decimal.Parse(textBox2.Text);
                secondNumber = decimal.Parse(textBox1.Text);
                total = firstNumber + secondNumber;
                calculationLabel.Text = total.ToString(""); //  Displays the total on the application

            }
            catch
            {
                //Display error message  when invalid data is entered
                MessageBox.Show("invalid data was entered");
                textBox2.Focus();
                textBox2.SelectAll();
            }   


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.codedPictureBox.Image = Image.FromFile("calculator.png"); // Displays the picture

                // Divides the numbers
                decimal firstNumber, secondNumber, total; // Variable declaration

                firstNumber = decimal.Parse(textBox2.Text);
                secondNumber = decimal.Parse(textBox1.Text);
                total = firstNumber / secondNumber;
                calculationLabel.Text = total.ToString(""); // Displays the total on the application
            }
            catch
            {
                //Display error message when invalid data is entered
                MessageBox.Show("invalid data was entered");
                textBox2.Focus();
                textBox2.SelectAll();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.codedPictureBox.Image = Image.FromFile("calculator.png"); // Displays the picture

                // Substract numbers
                decimal firstNumber, secondNumber, total;  // Variable declaration

                firstNumber = decimal.Parse(textBox2.Text);
                secondNumber = decimal.Parse(textBox1.Text);
                total = firstNumber - secondNumber;
                calculationLabel.Text = total.ToString(""); // Displays the total on the calculationLabel.

            }
            catch
            {
                //Display error message when invalid data is entered 
                MessageBox.Show("invalid data was entered");
                textBox2.Focus();
                textBox2.SelectAll();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        { // This Clears the Textboxs and label
            textBox1.Clear();
            textBox2.Clear();
            calculationLabel.Text ="";
            textBox2.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();  // this closes the application
        }
    }
}
