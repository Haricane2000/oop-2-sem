using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_WinForm
{
    public partial class Form1 : Form
    {
        int count;
        int a;
        double ans;

        CalculationMemory Mem;

        public Form1()
        {
            InitializeComponent();

            Mem = new CalculationMemory();
        }
        


        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e) // +
        {
            try
            {
                a = int.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();

                count = 1;
            }
            catch (FormatException)
            {
                MessageBox.Show("The number is not an integer");
            }
            catch
            {
                MessageBox.Show("Insert a number!");
            }
        }

        private void button11_Click(object sender, EventArgs e) // =
        {
            try
            {
                compute();
                count = 5;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("DivideByZeroException!!!");
                textBox1.Clear();
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Insert a number!");
            }
        }

        private void button13_Click(object sender, EventArgs e) // -
        {
            try
            {
                a = int.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();

                count = 2;
            }
            catch
            {
                MessageBox.Show("Insert a number!");
            }
        }

        private void button14_Click(object sender, EventArgs e) // /
        {
            try
            {
                a = int.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();

                count = 4;
            }
            catch(FormatException)
            {
                MessageBox.Show("The number is not an integer!!!");
                textBox1.Clear();
            }
        }

        private void button15_Click(object sender, EventArgs e) // *
        {
            try
            {
                a = int.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();

                count = 3;
            }
            catch
            {
                MessageBox.Show("Insert a number!");
            }
        }


       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public delegate void Message(); // DELEGATe
        public event Message Event;

        void message()
        {
            MessageBox.Show("Lets calculate!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Event += new Message(message);
            Event();
        }

        private void button16_Click(object sender, EventArgs e) // C
        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e) // M+
        {
            try
            {
                Mem.M_Sum(Double.Parse(textBox1.Text));
                ans = Double.Parse(textBox1.Text);

            }

            catch
            {
                MessageBox.Show("Inser a number!");
            }
        }

        private void button19_Click(object sender, EventArgs e) // M-
        {
            try
            {
                Mem.M_Sub(Double.Parse(textBox1.Text));
                ans = Double.Parse(textBox1.Text);

            }

            catch
            {
                MessageBox.Show("Inser a number!");
            }
        }

        private void button17_Click(object sender, EventArgs e) // <--
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        public void compute()
        {
            switch(count)
            {
                case 1:
                    ans = calculator.Add(a, int.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = calculator.Sub(a, int.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = calculator.Mult(a, int.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = calculator.Div(a, Double.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;
                case 5: //=
                    ans = calculator.Equally(a, Double.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;
                case 6:
                    ans = calculator.Div2(a, int.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;

                default:
                    break;
            }
        }
    }
}
