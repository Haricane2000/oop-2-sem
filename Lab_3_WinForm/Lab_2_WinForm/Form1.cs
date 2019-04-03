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

        List<Flat> search = new List<Flat>();
        List<Flat> sortCity = new List<Flat>();
        List<Flat> sortFloor = new List<Flat>();

        public Form1()
        {
            InitializeComponent();
            MetrComboBox.Items.AddRange(Flat.ListOfMetr);
            flat.Year = HouseAge.Value.ToString("dd-MM-yyyy");
            flat.CountOfRooms = (int)RoomsNumericUpDown1.Value;
            flat.Floor = (int)FLOORnumericUpDown2.Value;

            ////////////////////
            
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
                Adress temp = new Adress(adress.State, adress.City, adress.Street, adress.House, adress.FlatNumber);
                flat.adress = temp;
                flats.Add(flat);
                XmlSerializer formatter = new XmlSerializer(typeof(List<Flat>));
                using (FileStream fs = new FileStream("flats.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, flats);
                }

                textBox1.Text = "";
                flat = new Flat();

                this.MetrComboBox.Text = MetrComboBox.Items[0].ToString();
                this.flat.Year = HouseAge.Value.ToString("dd-MM-yyyy");
                this.flat.CountOfRooms = (int)RoomsNumericUpDown1.Value;
                this.flat.Floor = (int)FLOORnumericUpDown2.Value;

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
                textBox1.Text += flat.ShowAllInf();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


       

        private void toolStripMenuItemResOfSEARCH_Click(object sender, EventArgs e) 
        {
            try
            {
                if (search.Count == 0)
                {
                    throw new Exception("Не обнаружено результатов поиска.");
                }
                else
                {
                    using (FileStream fs = new FileStream("search.xml", FileMode.OpenOrCreate))
                    {
                        XmlSerializer ftt = new XmlSerializer(typeof(List<Flat>));
                        ftt.Serialize(fs, search);
                    }

                    MessageBox.Show("Результаты поиска сохранены.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItemResOfSORT_Click(object sender, EventArgs e)
        {
            try
            {
                
                    using (FileStream fs = new FileStream("sortCity.xml", FileMode.OpenOrCreate))
                    {
                        XmlSerializer ftt = new XmlSerializer(typeof(List<Flat>));
                        ftt.Serialize(fs, sortCity);
                    }

                    MessageBox.Show("Результаты сортировки сохранены.");
                


                
                    using (FileStream fs = new FileStream("sortFloor.xml", FileMode.OpenOrCreate))
                    {
                        XmlSerializer ftt = new XmlSerializer(typeof(List<Flat>));
                        ftt.Serialize(fs, sortFloor);
                    }

                    MessageBox.Show("Результаты сортировки сохранены.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItemCITY_Click(object sender, EventArgs e)
        {
            sortCity.Clear();
            textBox1.Text = "";
            var result = flats
                .OrderBy(p => p.adress.City);
            int i = 1;
            foreach (Flat fl in result)
            {
                textBox1.Text += i + ")";
                sortCity.Add(fl);
                textBox1.Text += fl.ShowAllInf();
                i++;
            }
        }

        private void toolStripButtonSEARCH_Click(object sender, EventArgs e)
        {

            FormSearch formSearch = new FormSearch(this);
            formSearch.ShowDialog();

            if (formSearch.result != null)
            {
                search = formSearch.result;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e) // about
        {
            MessageBox.Show("Версия 1.0\nРазработчик: Косовец Полина", "О программе");
        }

        private void toolStripMenuItemFLOOR_Click(object sender, EventArgs e)
        {
            sortFloor.Clear();
            textBox1.Text = "";
            var result = flats
                .OrderBy(p => p.Floor)
                .Select(p => p);
            int i = 1;
            foreach (Flat fl in result)
            {
                textBox1.Text += i + ")";
                sortFloor.Add(fl);
                textBox1.Text += fl.ShowAllInf();
                i++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
