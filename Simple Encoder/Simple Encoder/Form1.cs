using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Encoder
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int myShift = 1;

            textBox2.Text = Cipher(input, myShift);

        }
        private string Cipher(string origText, int Shift)
        {

            char[] origTxtArray = origText.ToCharArray();
            int FirstCharIndex = ' ';
            int number = ('~' - ' ') + 1;


            for (int i = 0; i < origTxtArray.Length; i++)
            {
                char CharIndex = origTxtArray[i];
                int CharIndexInAlpha = CharIndex - FirstCharIndex;
                int NewIndexInAlpha = (CharIndexInAlpha + Shift) % number;
                char NewCharIndex = (char)(FirstCharIndex + NewIndexInAlpha);

                if (CharIndex == ' ')
                {
                    NewCharIndex = ' ';
                }
                if (CharIndex == '.')
                {
                    NewCharIndex = '.';
                }
                if (CharIndex == '!')
                {
                    NewCharIndex = '!';
                }
                if (CharIndex == '?')
                {
                    NewCharIndex = '?';
                }
                if (CharIndex == ' ')
                {
                    NewCharIndex = ' ';
                }
                if (CharIndex == '.')
                {
                    NewCharIndex = '.';
                }
                if (CharIndex == ',')
                {
                    NewCharIndex = ',';
                }
                if (CharIndex == ':')
                {
                    NewCharIndex = ':';
                }
                if (CharIndex == ';')
                {
                    NewCharIndex = ';';
                }

                origTxtArray[i] = NewCharIndex;
            }
            return new string(origTxtArray);
        }
    }
}
