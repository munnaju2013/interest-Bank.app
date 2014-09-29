using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brac_bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private double capital = 0;
        private double year = 0;
        private double interest = 0;

        private void pressButton_Click(object sender, EventArgs e)
        {
            string bank = ShowComboBox.Text;
            //interestTextBox.Text.clear();
            if (bank == "BRAC 6%")
            {
                capital = Convert.ToDouble(capitalTextBox.Text);
                year = Convert.ToDouble(yearTextBox.Text);
                capitalTextBox.Text = "";
                yearTextBox.Text = "";

                interest = year*(capital*0.06);
                interestTextBox.Text = interest.ToString();
                interestTextBox.Text = String.Empty;
                //interestTextBox.Text = "";
            }
            else if (bank == "BDDL 7%")
            {
                capital = Convert.ToDouble(capitalTextBox.Text);
                year = Convert.ToDouble(yearTextBox.Text);
                capitalTextBox.Text = "";
                yearTextBox.Text = "";

                interest = year * (capital * 0.07);
                interestTextBox.Text = interest.ToString();
               // interestTextBox.Text = "";
            }
            else
            {
                capital = Convert.ToDouble(capitalTextBox.Text);
                year = Convert.ToDouble(yearTextBox.Text);
                capitalTextBox.Text = "";
                yearTextBox.Text = "";

                interest = year * (capital * 0.08);
                interestTextBox.Text = interest.ToString();
                //interestTextBox.Text = "";
            }
            interestTextBox.Clear();
        }
    }
}
