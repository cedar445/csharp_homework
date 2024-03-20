using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem2
{
    public partial class Form1 : Form
    {
        private double a, b;
        private string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double res;
            if (op == "+")
            {
                res = a + b;
                string tmp=res.ToString();
                outputRes.Text = tmp;
            }
            else if (op == "-")
            {
                res = a - b;
                string tmp = res.ToString();
                outputRes.Text = tmp;
            }
            else if (op == "*")
            {
                res = a * b;
                string tmp = res.ToString();
                outputRes.Text = tmp;
            }
            else if (op == "/")
            {
                res = a / b;
                string tmp = res.ToString();
                outputRes.Text = tmp;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = input1.Text;
            a = double.Parse(s);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            op = inputOp.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string s = input2.Text;
            b = double.Parse(s);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
