using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkylator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("/");
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("*");
        }

        private void roundButton6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("+");
        }

        private void roundButton7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("-");
        }

        private void roundButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                double result = Convert.ToDouble(new DataTable().Compute(textBox1.Text, null));
                textBox1.Text = result.ToString();
            } catch
            {
                textBox1.Text = "Error";
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }
    }
}
