using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD3_1302210083
{
    public partial class Form1 : Form
    {
        string temp = "";
        int digit = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text += "9";
            this.temp += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text += "+";
            this.digit += int.Parse(temp);
            temp = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label1.Text += "1";
            this.temp += "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.label1.Text += "2";
            this.temp += "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text += "3";
            this.temp += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label1.Text += "4";
            this.temp += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.label1.Text += "5";
            this.temp += "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text += "6";
            this.temp += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label1.Text += "7";
            this.temp += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label1.Text += "8";
            this.temp += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a = digit + int.Parse(temp);
            this.label1.Text = a.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label1.Text += "0";
        }
    }
}
