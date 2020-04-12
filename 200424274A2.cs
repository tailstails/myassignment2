using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Name: Taeler Burgess
/// Purpose: This is the memory calculator program that takes in decimal values, and can perform basic operations
/// and store memory
/// </summary>
/// 

namespace _200424274A2
{
    public partial class Calculator : Form
    {
        public Calculator() //Out calculator class
        {
            InitializeComponent();
        }

        /// <summary>
        /// All of these are the numeric buttons for the calculator, ranging from 0-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        // This displays the number 0 from the 0 button
        private void button0_Click(object sender, EventArgs e)
        {
            resultOutput.Text += 0;
        }

        // This displays the number 1 from the 1 button
        private void button1_Click(object sender, EventArgs e)
        {
            resultOutput.Text += 1;
        }

        // This displays the number 2 from the 2 button
        private void button2_Click(object sender, EventArgs e)
        {
            resultOutput.Text += 2;
        }

        // This displays the number 3 from the 3 button
        private void button3_Click(object sender, EventArgs e)
        {
            resultOutput.Text += 3;
        }

        // This displays the number 4 from the 4 button
        private void button4_Click(object sender, EventArgs e)
        {
            resultOutput.Text += 4;
        }

        // This displays the number 5 from the 5 button
        private void button5_Click(object sender, EventArgs e)
        {
            resultOutput.Text += 5;
        }

        // This displays the number 6 from the 6 button
        private void button6_Click(object sender, EventArgs e)
        {
            resultOutput.Text += 6;
        }

        // This displays the number 7 from the 7 button
        private void button7_Click(object sender, EventArgs e)
        {
            resultOutput.Text += 7;
        }

        // This displays the number 8 from the 8 button
        private void button8_Click(object sender, EventArgs e)
        {
            resultOutput.Text += 8;
        }

        // This displays the number 9 from the 9 button
        private void button9_Click(object sender, EventArgs e)
        {
            resultOutput.Text += 9; 
        }

        /// <summary>
        /// These are the one press simple buttons that work all the time. 
        /// Pretty much the sqrt, 1/X, decimal (.) and the +/- buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //This displays a negative sign only if there's not one there. If there is, it cuts it out and the number is positive
        private void plusNegativeBtn_Click(object sender, EventArgs e)
        {
            if (!resultOutput.Text.Contains("-"))
            {
                resultOutput.Text = "-" + resultOutput.Text;
            }

            else
            {
                resultOutput.Text = resultOutput.Text.Trim('-');
            }
        }

        //This method checks to see if the decimal is there. If it isn't it adds only ONE decimal 
        private void dotButton_Click(object sender, EventArgs e)
        {
            if (!resultOutput.Text.Contains('.'))
            {
                resultOutput.Text = resultOutput.Text + ".";
            }
        }

        //This button uses the Math.sqrt function, and gives it the square root when the button is pressed
        private void sqrtButton_Click(object sender, EventArgs e)
        {
            resultOutput.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(resultOutput.Text)));
        }

        //This button calculates the reciporal of a number when clicked
        private void reciprocalButton_Click(object sender, EventArgs e)
        {
            resultOutput.Text = (1 / Convert.ToDouble(resultOutput.Text)).ToString();
        }


    }
}
