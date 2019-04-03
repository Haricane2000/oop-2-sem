using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Lab_2_WinForm
{
    public partial class Form1 : Form
    {
        public Flat flat = new Flat();
        public Adress adress = new Adress();
        public List<Flat> flats = new List<Flat>();

        public Form1()
        {
            InitializeComponent();
            MetrComboBox.Items.AddRange(Flat.ListOfMetr);
            flat.Year = HouseAge.Value.ToString("dd-MM-yyyy");
            flat.CountOfRooms = (int)RoomsNumericUpDown1.Value;
            flat.Floor = (int)FLOORnumericUpDown2.Value;

           

        }

        private void AddAdressButton_Click(object sender, EventArgs e)
        {
            FormAdress formad = new FormAdress(this);
            formad.ShowDialog();
            flat.adress = adress;
        }
        
        private void MetrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            flat.Metr =Int32.Parse(comboBox.Text);
        }

        private void HouseAge_ValueChanged(object sender, EventArgs e)
        {
            flat.Year = HouseAge.Value.ToString("dd-MM-yyyy");
        }

        private void button1_Click(object sender, EventArgs e)// Save XML
        {
            try
            {
                flats.Add(flat);
                XmlSerializer formatter = new XmlSerializer(typeof(List<Flat>));
                using (FileStream fs = new FileStream("flats.xml", FileMode.Create))
                {
                    formatter.Serialize(fs, flats);
                }

                textBox1.Text = "";
                flat = new Flat();

                MetrComboBox.Text = MetrComboBox.Items[0].ToString();
                flat.Year = HouseAge.Value.ToString("dd-MM-yyyy");
                flat.CountOfRooms = (int)RoomsNumericUpDown1.Value;
                flat.Floor = (int)FLOORnumericUpDown2.Value;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RoomsNumericUpDown1_ValueChanged(object sender, EventArgs e) //
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked == true)
            {
                flat.rooms += "," + checkbox.Text;
            }
            else
            {
                MessageBox.Show("Отметь комнату");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked == true)
            {
                flat.rooms += "," + checkbox.Text;
            }
            else
            {
                MessageBox.Show("Отметь комнату");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked == true)
            {
                flat.rooms += "," + checkbox.Text;
            }
            else
            {
                MessageBox.Show("Отметь комнату");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked == true)
            {
                flat.rooms += "," + checkbox.Text;
            }
            else
            {
                MessageBox.Show("Отметь комнату");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked == true)
            {
                flat.rooms += "," + checkbox.Text;
            }
            else
            {
                MessageBox.Show("Отметь комнату");
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked == true)
            {
                flat.rooms += "," + checkbox.Text;
            }
            else
            {
                MessageBox.Show("Отметь комнату");
            }
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = flat.ShowAllInf();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
