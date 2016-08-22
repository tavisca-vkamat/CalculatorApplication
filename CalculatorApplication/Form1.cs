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

         public string div(int a,int b)
    {
        string s = "";
        double c = 0;
        c = a / b;
        if (b == 0)
        {
            s = "Invalid";


            return s;
        }
        else
            s = c.ToString();
        return s;

    }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            /*hi this is vivek*/
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
