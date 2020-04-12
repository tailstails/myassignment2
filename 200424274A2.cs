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
        String operationSign = ""; //This will hold the operators like +, -, *, and /
        
        double firstValue = 0; // This will be the first number that holds a value
        
        String memory; //This will hold the memory of the number that is being stored in there
        
        double finalValue; // This holds the result of the final value
        
        double secondValue; //This holds the second value (or number)
        




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



        /// <summary>
        /// We're making a back button and clear button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //Our method uses a substring so that it only cuts off a portion of the number, by one number
        //As kong as the length is greater than 0 of course
        private void backButton_Click(object sender, EventArgs e)
        {
            if (resultOutput.Text.Length > 0)
            {

                resultOutput.Text = resultOutput.Text.Substring(0, resultOutput.Text.Length - 1);
            }
        }

        //Our method shall clear up any data from the memory, and the regular textbox
        private void clearButton_Click(object sender, EventArgs e)
        {
            resultOutput.Text = "";
            memory = "";
            firstValue = 0;
            secondValue = 0;


        }


        /// <summary>
        /// Now, it'a time to give the basic operator buttons some life
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //The textbox will convert the string values in the textboxes to doubles
        //This is the division button
        private void divisionButton_Click(object sender, EventArgs e)
        {
            firstValue = Double.Parse(resultOutput.Text);
            resultOutput.Text = "";
            operationSign = "/";
        }

        //The textbox will convert the string values in the textboxes to doubles
        //This is the multipilcation button
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstValue = Double.Parse(resultOutput.Text);
            resultOutput.Text = "";
            operationSign = "*";
        }

        //The textbox will convert the string values in the textboxes to doubles
        //This is the subtration button
        private void subtractionButton_Click(object sender, EventArgs e)
        {
            firstValue = Double.Parse(resultOutput.Text);
            resultOutput.Text = "";
            operationSign = "-";
        }

        //The textbox will convert the string values in the textboxes to doubles
        //This is the addition button
        private void additionButton_Click(object sender, EventArgs e)
        {
            firstValue = Double.Parse(resultOutput.Text);
            resultOutput.Text = "";
            operationSign = "+";
        }


        /// <summary>
        /// Now, it'a time to give the basic operator buttons some life by creating an equals button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        //This is the equals button, where everything happens 
        private void equalsButton_Click(object sender, EventArgs e)
        {
          
            //Allows the textbox to take in a double

            secondValue = Double.Parse(resultOutput.Text);

            //If the sign is +, do addition
            if (operationSign == "+")
            {
                finalValue = (firstValue + secondValue);
                resultOutput.Text = Convert.ToString(finalValue);
                firstValue = finalValue;
            }

            //If the sign is -, do subtraction
            if (operationSign == "-")
            {
                finalValue = (firstValue - secondValue);
                resultOutput.Text = Convert.ToString(finalValue);
                firstValue = finalValue;
            }

            //If the sign is *, do multiplication
            if (operationSign == "*")
            {
                finalValue = (firstValue * secondValue);
                resultOutput.Text = Convert.ToString(finalValue);
                firstValue = finalValue;
            }

            //When the person divides, if the division symbol is found, and user divides by 0..
            //They get an error message 
            //Or else, they get their result and no error message

            if (operationSign == "/")
            {
                if (secondValue == 0)
                {
                    resultOutput.Text = "You cannot divide by 0. Try again please!";

                }
                else
                {
                    finalValue = (firstValue / secondValue);
                    resultOutput.Text = Convert.ToString(finalValue);
                    firstValue = finalValue;
                }

            }


        }
    }
}