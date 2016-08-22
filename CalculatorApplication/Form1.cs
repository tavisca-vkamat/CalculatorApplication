using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
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

        private void button15_Click(object sender, EventArgs e)
        {
           /* get user input and parse it to integer*/
            String textOfInput = textBox1.Text;
            String[] numArray= null;
            if (textOfInput.Contains("+"))
            {
                numArray = textOfInput.Split('+');
            }
            if (textOfInput.Contains("-"))
            {
                numArray = textOfInput.Split('-');
            }
            if (textOfInput.Contains("*"))
            {
                numArray = textOfInput.Split('*');
            }
            if (textOfInput.Contains("/"))
            {
                numArray = textOfInput.Split('/');
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }


        public string mul(int a, int b)
        {
            return (a * b) + "";
        }
    }
}
