using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeColorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Green;
            MessageBox.Show("Color Selection was: Geen");
        }

        private void buttonGray_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Gray;
            MessageBox.Show("Color Selection was: Gray");
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Yellow;
            MessageBox.Show("Color Selection was: Yellow");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Blue;
        }
    }
}
