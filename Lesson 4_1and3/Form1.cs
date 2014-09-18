using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lesson_4_1and3
{
    public partial class Form1 : Form
    {
        double number, answer;   
        int countnumber;
        
        public Form1()
        {
            InitializeComponent();
        }

        //Entry() method
        public void Entry()
        {
            //Reads and converts txtEntry to a double called NUMBER 
            number = double.Parse(txtEntry.Text);
            //txtEntry is cleared and focused
            txtEntry.Clear();
            txtEntry.Focus();
            
        }

        // MessageboxInputError1() method
        public void MessageboxInputError1()
        {
            //Messagebox appears when the user leave the textbox txtEntry blank and a function or operator is selected 
            MessageBox.Show("Please input digits to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Clears txtEntry and lblStatus and focuses on txtEntry
            txtEntry.Clear();
            lblStatus.Text = "";
            txtEntry.Focus(); 
        }

        //MessageboxInputError2() method
        public void MessageboxInputError2()
        {
            //Messagebox appears when the user enters an input that consists of letters or symbols
            MessageBox.Show("Please assure that all inputs consist of digits only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Clears txtEntry and lblStatus and focuses on txtEntry
            txtEntry.Clear();
            lblStatus.Text = "";
            txtEntry.Focus(); 
        } 

        //This method disables all buttons preventing user from spamming 
        public void Disablebuttons() 
        {
            btnSin.Enabled = false;
            btnCos.Enabled = false;
            btnTan.Enabled = false;
            btnExp.Enabled = false; 
            btnRoot.Enabled = false;
            btnMultiplication.Enabled = false;
            btnDivision.Enabled = false; 
            btnAddition.Enabled = false;
            btnSubtraction.Enabled = false;
            btnEuler.Enabled = false;
            btnPi.Enabled = false;
            btnZero.Enabled = false;
            btnOne.Enabled = false;
            btnTwo.Enabled = false;
            btnThree.Enabled = false;
            btnFour.Enabled = false;
            btnFive.Enabled = false;
            btnSix.Enabled = false;
            btnSeven.Enabled = false;
            btnEight.Enabled = false;
            btnNine.Enabled = false;
            btnEqual.Enabled = false;
            lblNotice.Text = "*To perform further calculations, click AC to clear all.";
        }

        // This method validates all buttons after they have been disabled
        public void Validatebuttons()
        {
            btnSin.Enabled = true;
            btnCos.Enabled = true;
            btnTan.Enabled = true;
            btnExp.Enabled = true;
            btnRoot.Enabled = true;
            btnMultiplication.Enabled = true;
            btnDivision.Enabled = true;
            btnAddition.Enabled = true;
            btnSubtraction.Enabled = true;
            btnEuler.Enabled = true;
            btnPi.Enabled = true;
            btnZero.Enabled = true;
            btnOne.Enabled = true;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;
            btnEqual.Enabled = true;
            lblNotice.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears txtEntry and lblStatus and focuses on txtEntry
            txtEntry.Clear();
            lblStatus.Text = ""; 
            txtEntry.Focus();
            Validatebuttons(); 
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            //Digit zero is entered into the textbox txtEntry
            txtEntry.Text = txtEntry.Text + "0"; 
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            //Digit zone is entered into the textbox txtEntry
            txtEntry.Text = txtEntry.Text + "1"; 
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            //Digit two is entered into the textbox txtEntry
            txtEntry.Text = txtEntry.Text + "2"; 
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            //Digit three is entered into the textbox txtEntry
            txtEntry.Text = txtEntry.Text + "3"; 
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            //Digit four is entered into the textbox txtEntry
            txtEntry.Text = txtEntry.Text + "4"; 
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            //Digit five is entered into the textbox txtEntry
            txtEntry.Text = txtEntry.Text + "5"; 
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            //Digit six is entered into the textbox txtEntry
            txtEntry.Text = txtEntry.Text + "6"; 
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            //Digit seven is entered into the textbox txtEntry
            txtEntry.Text = txtEntry.Text + "7"; 
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            //Digit eight is entered into the textbox txtEntry
            txtEntry.Text = txtEntry.Text + "8"; 
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            //Digit nine is entered into the textbox txtEntry
            txtEntry.Text = txtEntry.Text + "9"; 
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            //Constant pi is rounded to five decimal places and entered into the textbox txtEntry
            txtEntry.Text = Math.Round((Math.PI),5).ToString();
        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            //Constant E is rounded to five decimal places and entered into the textbox txtEntry
            txtEntry.Text = Math.Round((Math.E), 5).ToString(); 
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
                try
                {
                    //If the input is not empty
                    if (txtEntry.Text != "")
                    {
                        //The input value is copied onto lblStatus with an addition operator
                        lblStatus.Text = lblStatus.Text + txtEntry.Text + " + ";
                        Entry();
                        // Variable countnumber is assigned a value of 2 for a future switchcase 
                        countnumber = 2;
                    }

                    //If the input is empty
                    else if (txtEntry.Text == "")
                    {
                        MessageboxInputError1();
                    }
                }
                catch
                {
                    MessageboxInputError2(); 
                }
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
                try
                {
                    //If the input is not empty
                    if (txtEntry.Text != "")
                    {
                        //The input value is copied onto lblStatus with a subtraction operator
                        lblStatus.Text = lblStatus.Text + txtEntry.Text + " - ";
                        Entry();
                        // Variable countnumber is assigned a value of 1 for a future switchcase
                        countnumber = 1;
                    }

                    // If the input is empty
                    else if (txtEntry.Text == "")
                    {
                        MessageboxInputError1();
                    }
                }
                catch
                {
                    MessageboxInputError2(); 
                }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                //If the input is not empty
                if (txtEntry.Text != "")
                {
                    //The input value is copied onto lblStatus with a mulitplication operator
                    lblStatus.Text = lblStatus.Text + txtEntry.Text + " x ";
                    Entry();
                    // Variable countnumber is assigned a value of 3 for a future switchcase
                    countnumber = 3;
                }

                // If the input is empty
                else if (txtEntry.Text == "")
                {
                    MessageboxInputError1();
                }
            }
            catch
            {
                MessageboxInputError2(); 
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                //If the input is not empty
                if (txtEntry.Text != "")
                {
                    //The input value is copied onto lblStatus with a division operator
                    lblStatus.Text = lblStatus.Text + txtEntry.Text + " / ";
                    Entry();
                    // Variable countnumber is assigned a value of 4 for a future switchcase
                    countnumber = 4;
                }

                // If the input is empty
                else if (txtEntry.Text == "")
                {
                    MessageboxInputError1();
                }
            }
            catch
            {
                MessageboxInputError2(); 
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            try
            {
                //If the input is not empty
                if (txtEntry.Text != "")
                {
                    //The input value is copied onto lblStatus with the exponential operator
                    lblStatus.Text = lblStatus.Text + txtEntry.Text + " ^ ";
                    Entry();
                    // Variable countnumber is assigned a value of 5 for a future switchcase
                    countnumber = 5;
                }

                // If the input is empty
                else if (txtEntry.Text == "")
                {
                    MessageboxInputError1();
                }
            }
            catch
            {
                MessageboxInputError2(); 
            }
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            try
            {
                //If the input is not empty
                if (txtEntry.Text != "")
                {
                    //The input value is copied onto lblStatus with the root operator
                    lblStatus.Text = lblStatus.Text + txtEntry.Text + " ^ 1/";
                    Entry();
                    // Variable countnumber is assigned a value of 6 for a future switchcase
                    countnumber = 6;
                }

                // If the input is empty
                else if (txtEntry.Text == "")
                {
                    MessageboxInputError1();
                }
            }
            catch
            {
                MessageboxInputError2(); 
            }

        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                //If the input is not empty
                if (txtEntry.Text != "")
                {
                    //The input value is copied onto lblStatus with the sine function
                    lblStatus.Text = lblStatus.Text + txtEntry.Text + " sin ";
                    Entry();
                    // Variable countnumber is assigned a value of 7 for a future switchcase
                    countnumber = 7;
                }

                // If the input is empty
                else if (txtEntry.Text == "")
                {
                    MessageboxInputError1();
                }
            }
            catch
            {
                MessageboxInputError2(); 
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                //If the input is not empty
                if (txtEntry.Text != "")
                {
                    //The input value is copied onto lblStatus with the cosine function
                    lblStatus.Text = lblStatus.Text + txtEntry.Text + " cos ";
                    Entry();
                    // Variable countnumber is assigned a value of 8 for a future switchcase
                    countnumber = 8;
                }

                //If the input is empty
                else if (txtEntry.Text == "")
                {
                    MessageboxInputError1();
                }
            }
            catch
            {
                MessageboxInputError2(); 
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                //If the input is not empty
                if (txtEntry.Text != "")
                {
                    //The input value is copied onto lblStatus with the tangent function
                    lblStatus.Text = lblStatus.Text + txtEntry.Text + " tan ";
                    Entry();
                    // Variable countnumber is assigned a value of 9 for a future switchcase
                    countnumber = 9;
                }

                //If the input is empty
                else if (txtEntry.Text == "")
                {
                    MessageboxInputError1();
                }
            }
            catch
            {
                MessageboxInputError2(); 
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                //If the input is not empty
                if (txtEntry.Text != "")
                {
                    //Switchcase for the variable countnumber
                    //Used to determine which function or operator is selected and what its assigned function should be
                    switch (countnumber)
                    {
                        case 1:
                            //The second value is read, converted to a double and subtracted from the first value
                            //The answer is rounded to three decimal places 
                            answer = Math.Round((number - double.Parse(txtEntry.Text)), 3);
                            //The answer is copied to lblStatus after an equal sign along with the initial values in lblStatus
                            lblStatus.Text = lblStatus.Text + txtEntry.Text + " = " + answer;
                            //The answer is converted back to a string and displayed in txtEntry
                            txtEntry.Text = answer.ToString();
                            Disablebuttons(); 
                            break;

                        case 2:
                            //The second value is read, converted to a double and added to the first value
                            //The answer is rounded to three decimal places 
                            answer = Math.Round((number + double.Parse(txtEntry.Text)), 3);
                            //The answer is copied to lblStatus after an equal sign along with the initial values in lblStatus
                            lblStatus.Text = lblStatus.Text + txtEntry.Text + " = " + answer;
                            //The answer is converted back to a string and displayed in txtEntry
                            txtEntry.Text = answer.ToString();
                            Disablebuttons(); 
                            break;

                        case 3:
                            //The second value is read, converted to a double and multiplied with the first value
                            //The answer is rounded to three decimal places 
                            answer = Math.Round((number * double.Parse(txtEntry.Text)), 3);
                            //The answer is copied to lblStatus after an equal sign along with the initial values in lblStatus
                            lblStatus.Text = lblStatus.Text + txtEntry.Text + " = " + answer;
                            //The answer is converted back to a string and displayed in txtEntry
                            txtEntry.Text = answer.ToString();
                            Disablebuttons(); 
                            break;

                        case 4:
                            //The second value is read, converted to a double and divided from the first value
                            //The answer is rounded to three decimal places 
                            answer = Math.Round((number / double.Parse(txtEntry.Text)), 3);
                            //The answer is copied to lblStatus after an equal sign along with the initial values in lblStatus
                            lblStatus.Text = lblStatus.Text + txtEntry.Text + " = " + answer;
                            //The answer is converted back to a string and displayed in txtEntry
                            txtEntry.Text = answer.ToString();
                            Disablebuttons(); 
                            break;

                        case 5:
                            //The second value is read, converted to a double and becomes a power to the first value
                            //The answer is rounded to three decimal places 
                            answer = Math.Round((Math.Pow(number, double.Parse(txtEntry.Text))), 3);
                            //The answer is copied to lblStatus after an equal sign along with the initial values in lblStatus
                            lblStatus.Text = lblStatus.Text + txtEntry.Text + " = " + answer;
                            //The answer is converted back to a string and displayed in txtEntry
                            txtEntry.Text = answer.ToString();
                            Disablebuttons(); 
                            break;

                        case 6:
                            //The second value is read, converted to a double and becomes the root to the first value
                            //The answer is rounded to three decimal places 
                            answer = Math.Round((Math.Pow(number, 1 / double.Parse(txtEntry.Text))), 3);
                            //The answer is copied to lblStatus after an equal sign along with the initial values in lblStatus
                            lblStatus.Text = lblStatus.Text + txtEntry.Text + " = " + answer;
                            //The answer is converted back to a string and displayed in txtEntry
                            txtEntry.Text = answer.ToString();
                            Disablebuttons(); 
                            break;

                        case 7:
                            //The second value is read, converted to a double, expressed as a sine value, and multiplied by the first value 
                            //The answer is rounded to three decimal places 
                            answer = Math.Round((number * Math.Sin(double.Parse(txtEntry.Text) * (Math.PI / 180))), 3);
                            //The answer is copied to lblStatus after an equal sign along with the initial values in lblStatus
                            lblStatus.Text = lblStatus.Text + txtEntry.Text + " = " + answer;
                            //The answer is converted back to a string and displayed in txtEntry
                            txtEntry.Text = answer.ToString();
                            Disablebuttons(); 
                            break;

                        case 8:
                            //The second value is read, converted to a double, expressed as a cosine value, and multiplied by the first value 
                            //The answer is rounded to three decimal places 
                            answer = Math.Round((number * Math.Cos(double.Parse(txtEntry.Text) * (Math.PI / 180))), 3);
                            //The answer is copied to lblStatus after an equal sign along with the initial values in lblStatus
                            lblStatus.Text = lblStatus.Text + txtEntry.Text + " = " + answer;
                            //The answer is converted back to a string and displayed in txtEntry
                            txtEntry.Text = answer.ToString();
                            Disablebuttons(); 
                            break;

                        case 9:
                            //The second value is read, converted to a double, expressed as a tangent value, and multiplied by the first value 
                            //The answer is rounded to three decimal places 
                            answer = Math.Round((number * Math.Tan(double.Parse(txtEntry.Text) * (Math.PI / 180))), 3);
                            //The answer is copied to lblStatus after an equal sign along with the initial values in lblStatus
                            lblStatus.Text = lblStatus.Text + txtEntry.Text + " = " + answer;
                            //The answer is converted back to a string and displayed in txtEntry
                            txtEntry.Text = answer.ToString();
                            Disablebuttons(); 
                            break;

                        default:
                            number = double.Parse(txtEntry.Text);
                            //boolean variable tempnum is set to true when input value is an integer
                            bool tempnum = true;
                            //If input is a variable and no function or operator is selected
                            if(tempnum == true)  
                            {
                            //If no operator or function is selected for a value, then lblStatus expresses it as a value that equals the inital value 
                            lblStatus.Text = txtEntry.Text + " = " + txtEntry.Text;
                            //txtEntry is cleared
                            txtEntry.Clear();
                            Disablebuttons(); 
                            }

                            //If input variable is not an integer and consists of letters and symbols
                            else if (tempnum == false)
                            {
                                MessageboxInputError2(); 
                            }
                            break;
                    }
                }
                 
                //If the input is empty
                else if (txtEntry.Text == "")
                {
                    MessageboxInputError1();
                }
            }
            catch
            {
                MessageboxInputError2(); 
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit(); 
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Messagebox is displayed telling the user the format for the functions and operators
            MessageBox.Show("The following are mathematical functions along with their recommended input format." + "\n" + "Note that A is the first input value and B is the second input value." + "\n" + "" + "\n" + "Sin: AsinB" + "\n" + "" + "\n" + "Cos: AcosB" + "\n" + "" + "\n" + "Tan: AtanB" + "\n" + "" + "\n" + "Exp: A^B" + "\n" + "" + "\n" + "Root: A^(1/B)" + "\n" + "" + "\n" + "Multiplication: A*B" + "\n" + "" + "\n" + "Division: A/B" + "\n" + "" + "\n" + "Addition: A + B" + "\n" + "" + "\n" + "Subtraction: A - B", "Operator and Function Formatting", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Messagebox appears telling the user how to pilot the program
            MessageBox.Show("Hello user! Welcome to Calculator! Please review the following instructions to pilot the program." + "\n" + "" + "\n" + "1. Use the keypad to enter a value." + "\n" + "" + "\n" + "2. Select a function or operator to determine how the second input value will affect the first input value. Refer to FORMAT under HELP if any confusion occurs." + "\n" + "" + "\n" + "3. Use the keypad to enter the second value." + "\n" + "" + "\n" + "Click the equal button to determine the answer." + "\n" + "" + "\n" + "4. Click AC to start again or click EXIT to exit the program." + "\n" + "" + "\n" + "Enjoy!", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}
