using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string oprtn="";
        bool optn = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if((textBox1.Text == "0")||(optn))

            textBox1.Clear();
                Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            optn = false;
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void op_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            oprtn = button.Text;
            value = Double.Parse(textBox1.Text);
            optn = true;
            textBox2.Text = textBox1.Text + button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          switch(oprtn){
                 case"+":
                    textBox1.Text =(value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "x":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }
    }
}
