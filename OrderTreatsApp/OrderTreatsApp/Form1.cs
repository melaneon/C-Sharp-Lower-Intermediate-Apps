using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderTreatsApp
{
    public partial class Roam : Form
    {
        string numberSelected = "";
        public Roam()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            lstMenu.ClearSelected();
            lstSelected.Items.Clear();
            quant.Text = "";
        }

        private void quant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (quant.SelectedItem == "1")
            {
                numberSelected = "1";
                
            }
            if (quant.SelectedItem == "2")
            {
                numberSelected = "2";
            }
            if (quant.SelectedItem == "3")
            {
                numberSelected = "3";
            }
            if (quant.SelectedItem == "4")
            {
                numberSelected = "4";
            }
            if (quant.SelectedItem == "5")
            {
                numberSelected = "5";
            }
            if (quant.SelectedItem == "6")
            {
                numberSelected = "6";
            }
            if (quant.SelectedItem == "7")
            {
                numberSelected = "7";
            }
            if (quant.SelectedItem == "8")
            {
                numberSelected = "8";
            }
            if (quant.SelectedItem == "9")
            {
                numberSelected = "9";
            }
            if (quant.SelectedItem == "10")
            {
                numberSelected = "10";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CheckFor1();
            CheckFor2();
            CheckFor3();
            CheckFor4();
            CheckFor5();
            lstMenu.ClearSelected();
            quant.Text = "";

        }
        private void CheckFor1()
        {
            int index = lstSelected.FindString("Sugar Cookie");

            if (lstMenu.SelectedItems.Contains("Sugar Cookie"))
            {
                if (index == -1)
                {
                    lstSelected.Items.Add($"Sugar Cookie quantity: {numberSelected}");
                }
            }
        }
        private void CheckFor2()
        {
            int index = lstSelected.FindString("Gingerbread Cookie");

            if (lstMenu.SelectedItems.Contains("Gingerbread Cookie"))
            {
                if (index == -1)
                {
                    lstSelected.Items.Add($"Gingerbread Cookie quantity: {numberSelected}");
                }
            }
        }
        private void CheckFor3()
        {
            int index = lstSelected.FindString("Stollen");

            if (lstMenu.SelectedItems.Contains("Stollen"))
            {
                if (index == -1)
                {
                    lstSelected.Items.Add($"Stollen quantity: {numberSelected}");
                }
            }
        }
        private void CheckFor4()
        {
            int index = lstSelected.FindString("Fruit Cake");

            if (lstMenu.SelectedItems.Contains("Fruit Cake"))
            {
                if (index == -1)
                {
                    lstSelected.Items.Add($"Fruit Cake quantity: {numberSelected}");
                }
            }
        }
        private void CheckFor5()
        {
            int index = lstSelected.FindString("Peppermint Cane");

            if (lstMenu.SelectedItems.Contains("Peppermint Cane"))
            {
                if (index == -1)
                {
                    lstSelected.Items.Add($"Peppermint Cane quantity: {numberSelected}");
                }
            }
        }
    }
}
