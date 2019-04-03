using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_WinForm
{
    public partial class FormAdress : Form
    {
        Form1 Mainform;
        public FormAdress(Form1 form1)
        {
            Mainform = form1;
            InitializeComponent();
            buttonOK.Enabled = false;
            textBoxSTREET.Tag = false;
            textBoxHouse.Tag = false;
            comboBoxSTATE.Items.AddRange(Adress.ListOfSTATE);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private string GetCity()
        {
            if (radioButton1.Checked)
            {
                return radioButton1.Text;
            }

            if (radioButton2.Checked)
            {
                return radioButton2.Text;
            }

            if (radioButton3.Checked)
            {
                return radioButton3.Text;
            }

            if (radioButton4.Checked)
            {
                return radioButton4.Text;
            }

            if (radioButton5.Checked)
            {
                return radioButton5.Text;
            }

            if (radioButton6.Checked)
            {
                return radioButton6.Text;
            }
            return " ";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Mainform.adress.State = comboBoxSTATE.Text;
            Mainform.adress.City = GetCity();
            Mainform.adress.Street = textBoxSTREET.Text;
            Mainform.adress.House = textBoxHouse.Text;
            Mainform.adress.FlatNumber = (int)numericUpDownFlat.Value;

            Close();
            Mainform.Show();
        }

        private void textBoxSTREET_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox tb = (TextBox)sender;
                if (tb.Text.Length == 0)
                {
                    tb.BackColor = Color.Red;
                    tb.Tag = false;
                }
                else
                {
                    tb.BackColor = SystemColors.Window;
                    tb.Tag = true;
                }
                ValidateOK();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ValidateOK()
        {
            buttonOK.Enabled = ((bool)textBoxSTREET.Tag ) ;
        }

        

        private void textBoxHouse_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSTATE_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Mainform.adress.State = comboBox.Text;
        }

        private void FormAdress_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
