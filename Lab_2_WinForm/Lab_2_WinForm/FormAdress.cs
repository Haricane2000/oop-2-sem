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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Mainform.adress.State = comboBoxSTATE.Text;
            Mainform.adress.City = radioButton1.Text;
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
    }
}
