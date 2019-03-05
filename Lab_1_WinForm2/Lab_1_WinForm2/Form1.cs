using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_WinForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> list = new List<int>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // size
        {
            
        }


        private void button5_Click(object sender, EventArgs e) // MAX
        {
            if (textBox1.Text == "0" || textBox1.Text == "")
            {
                this.list = null;
            }
            else
            {
                textBox1.Clear();
                int MaxEl = list.Max();
                textBox1.Text = MaxEl.ToString();
            }
            /////
            
        }

       
        private void GenerationButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (textBox2.Text == "" || textBox2.Text == "0")
                {
                    throw new Exception("Enter the size!");
                }
                else
                {
                    textBox1.Clear(); //////////////////////////////////////////////////
                    int size = int.Parse(textBox2.Text);
                    Random rand = new Random();
                    int[] number = new int[size];
                    
                    for ( int i = 0; i < size; i++)
                    {
                        number[i] = rand.Next(10);
                        list.Add(number[i]);
                    }
                    
                    foreach (int n in list)
                    {
                        textBox1.Text = textBox1.Text + " " + n.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void SizeButton_Click(object sender, EventArgs e)
        {

        }

        private void SortedButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "")
            {
                this.list = null;
            }
            else
            {
                textBox1.Clear();
                list.Sort();
                foreach (int l in list)
                {
                    textBox1.Text = textBox1.Text + " " + l.ToString();
                }
            }
        }

        private void SorteButton2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "")
            {
                this.list = null;
            }
            else
            {
                textBox1.Clear();
                list.Sort();
                list.Reverse();
                foreach (int l in list)
                {
                    textBox1.Text = textBox1.Text + " " + l.ToString();
                }
            }
        }

        private void SearchMINbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "")
            {
                this.list = null;
            }
            else
            {
                textBox1.Clear();
                int MinEl = list.Min();
                textBox1.Text = MinEl.ToString();
            }
        }
    }
}
