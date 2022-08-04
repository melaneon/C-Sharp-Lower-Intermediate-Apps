using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimedMathQuiz
{

    public partial class Form1 : Form
    {

        int secondsCounter = 0;

        public Form1()
        {

            InitializeComponent();
            lblMessage.Visible = false;
            this.ActiveControl = textBox1;
            textBox1.Focus();

            StartTheTime();

            GenerateRandomAdditions();
            void GenerateRandomAdditions()
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 10);
                int randomNumber1 = random.Next(1, 10);
                int randomNumber2 = random.Next(1, 10);
                int randomNumber3 = random.Next(1, 10);
                int randomNumber4 = random.Next(1, 10);
                int randomNumber5 = random.Next(1, 10);

                label1.Text = Convert.ToString(randomNumber);
                label3.Text = Convert.ToString(randomNumber1);
                label5.Text = Convert.ToString(randomNumber2);
                label9.Text = Convert.ToString(randomNumber3);
                label6.Text = Convert.ToString(randomNumber4);
                label12.Text = Convert.ToString(randomNumber5);
            }
        }

        private void StartTheTime()
        {
            timer1.Start();
            lblTimer.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsCounter++;
            lblTimer.Text = Convert.ToString(secondsCounter) + " seconds";
        }

        public bool CheckAnswers(string firstValue, string secondValue, string theAnswer)
        //I moved it out from Form1 to be able call it in the _KeyDown() methods.
        {
            int theAnswerInt = Convert.ToInt32(theAnswer);
            int value1 = Convert.ToInt32(firstValue);
            int value2 = Convert.ToInt32(secondValue);
            bool checkedanswer = true;
            int rightAnswer = value1 + value2;

            if (theAnswerInt == rightAnswer)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Right answer";
            }
            else if (theAnswerInt != rightAnswer)
            {
                lblMessage.Text = "Wrong Answer";
                lblMessage.Visible = true;                
                checkedanswer = false;
            }
            return checkedanswer;
        }
        public bool CheckNumeral(string theValue)
        {
            bool numeral = true;
            if (
            Int32.TryParse(theValue, out int theAnswerInt) == false)
            {
                numeral = false;
            }
            return numeral;
        }

        private void btbRestart_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true;
            Form F1 = new Form1();
            F1.Show();
            this.Hide();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CheckNumeral(textBox1.Text) == false)
                {
                    textBox1.Clear();
                    lblMessage.Visible = true;
                    lblMessage.Text = "Input must be numeral";
                }
                else
                {
                    if (CheckAnswers(label1.Text, label3.Text, textBox1.Text) == false)
                    {
                        textBox1.Clear();
                    }
                    else
                    {
                        textBox2.Focus();
                    }
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CheckNumeral(textBox2.Text) == false)
                {
                    textBox2.Clear();
                    lblMessage.Visible = true;
                    lblMessage.Text = "Input must be numeral";
                }
                else
                {
                    if (CheckAnswers(label5.Text, label9.Text, textBox2.Text) == false)
                    {
                        textBox2.Clear();
                    }
                    else
                    {
                        textBox3.Focus();
                    }
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CheckNumeral(textBox3.Text) == false)
                {
                    textBox3.Clear();
                    lblMessage.Visible = true;
                    lblMessage.Text = "Input must be numeral";
                }
                else
                {
                    if (CheckAnswers(label6.Text, label12.Text, textBox3.Text) == false)
                    {
                        textBox3.Clear();
                    }

                    if (CheckAnswers(label1.Text, label3.Text, textBox1.Text) == true &&
                   CheckAnswers(label5.Text, label9.Text, textBox2.Text) == true &&
                   CheckAnswers(label6.Text, label12.Text, textBox3.Text) == true)
                    {
                        lblMessage.Visible = true;
                        lblMessage.Text = $"Good job! All answers right!\nYour time: {Convert.ToString(secondsCounter)} ";
                        timer1.Stop();
                    }
                    else
                    {
                        lblMessage.Visible = true;
                        lblMessage.Text = "Not all answers correct. Please check it out again.";
                    }
                }

            }
        }
    }
}
