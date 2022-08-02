using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalc
{
    public partial class Form1 : Form
    {
        int Result;
        int valueFirst;
        int valueSecond;

        public Form1()
        {
            InitializeComponent();
        }

        //I fixed my logical errors, now Calculator denies all values <=0 and non-int values!!
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(value1.Text, out valueFirst) == true &&
                int.TryParse(value2.Text, out valueSecond) == true)
            {
                if (valueFirst <= 0 || valueSecond <= 0)
                {
                    labelWrong.Visible = true;
                    labelResult.Visible = false;
                }

                else if (valueFirst > 0 || valueSecond > 0)
                {
                    labelWrong.Visible = false;
                    Result = valueFirst + valueSecond;
                    labelResult.Text = $"Result = {Result.ToString()}";
                    labelResult.Visible = true;
                }
            }
            else 
            {
                labelWrong.Visible = true;
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (int.TryParse(value1.Text, out valueFirst) == true &&
                int.TryParse(value2.Text, out valueSecond) == true)
            {
                if (valueFirst <= 0 || valueSecond <= 0)
                {
                    labelWrong.Visible = true;
                    labelResult.Visible = false;
                }

                else if (valueFirst > 0 || valueSecond > 0)
                {
                    labelWrong.Visible = false;
                    Result = valueFirst * valueSecond;
                    labelResult.Text = $"Result = {Result.ToString()}";
                    labelResult.Visible = true;
                }
            }
            else
            {
                labelWrong.Visible = true;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            value1.Clear();
            value2.Clear();
            Result = 0;
            labelWrong.Visible= false;
            labelResult.Visible = false;
        }

    }
}
