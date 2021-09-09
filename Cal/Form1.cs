using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum Actions { SUMM, MINUS, MULTI, DIV, NOTHING }
        Actions Y = Actions.NOTHING;

        private double result;
        private void SetResult(double Num, Actions action)
        {
            
            switch (action)
            {
                case Actions.SUMM: 
                    result = result + Num;
                    break;
                case Actions.MINUS:
                    result = result - Num;
                    break;
                case Actions.MULTI:
                    result = result * Num;
                    break;
                case Actions.DIV:
                    result = result / Num;
                    break;
                case Actions.NOTHING:

                    break;
            }
                
        }
        //Clicks
private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                DialogResult a = MessageBox.Show("Error", "Error with nums;", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
            label1.Text = label1.Text + (sender as Button).Text;
            textBox1.Text = textBox1.Text+(sender as Button).Text; 
        }
        //SUMM

        private void button12_Click(object sender, EventArgs e)
        {
            Y = Actions.SUMM;
            if (textBox1.Text != "")
            { 
                result = Convert.ToDouble(textBox1.Text);
                
                textBox1.Text = "";
            }
        }
        //MINUS
private void button15_Click(object sender, EventArgs e)
        {
            Y = Actions.MINUS;
            if (textBox1.Text != "")
            {
                result = Convert.ToDouble(textBox1.Text);
                
                textBox1.Text = "";
            }
        }
        //MULTI
private void button14_Click(object sender, EventArgs e)
        {
            Y = Actions.MULTI;
            if (textBox1.Text!= "")
            {
                result = Convert.ToDouble(textBox1.Text);
                
                textBox1.Text = "";
            }
        }
        //DIV
private void button11_Click(object sender, EventArgs e)
        {
            Y = Actions.DIV;
            if (textBox1.Text != "")
            {
                result = Convert.ToDouble(textBox1.Text);
                
                textBox1.Text = "";
            }
        }
        //EQUALLY
private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                
                SetResult(Convert.ToDouble(textBox1.Text), Y);
                Y = Actions.NOTHING;
                textBox1.Text = Convert.ToString(result);
            }
        }
        //CANCEL
        private void button16_Click(object sender, EventArgs e)
        {
            result = 0;
            textBox1.Text = "";
        }
    }
    
}
