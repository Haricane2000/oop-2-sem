using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab_2_WinForm
{
    public partial class FormSearch : Form
    {
        public List<Flat> result = new List<Flat>();
        public Form1 data;
        public string floors;
        public string citys;

        public FormSearch(Form1 flats)
        {
            InitializeComponent();
            data = flats;
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (CountOfRoomscheckBox.Checked && CitycheckBox.Checked)
            {
                floors = textBox1.Text;
                citys = textBox2.Text;
                if (floors == "")
                    textBox1.BackColor = Color.Tomato;
                else
                    textBox1.BackColor = Color.White;
                if (citys == "")
                    textBox2.BackColor = Color.Tomato;
                else
                {
                    textBox2.BackColor = Color.White;
                    Search(floors, citys);
                }
            }
            else if (CountOfRoomscheckBox.Checked)
            {
                textBox1.Text = "";
                floors = textBox1.Text;
                if (floors == "")
                    textBox1.BackColor = Color.Tomato;
                else
                {
                    textBox1.BackColor = Color.White;
                    Search(floors, null);
                }
            }
            else if (CitycheckBox.Checked)
            {
                textBox2.Text = "";
                citys = textBox2.Text;
                if (citys == "")
                    textBox2.BackColor = Color.Tomato;
                else
                {
                    textBox2.BackColor = Color.White;
                    Search(null, citys);
                }
            }
            else
            {
                MessageBox.Show("Обозначьте критерий поиска");
            }
        }

        private void Search(string rooms, string citys)
        {
            result.Clear();
            dataGridView1.Rows.Clear();
            if (floors == null)
            {
                char c = citys[0];
                Regex regex = new Regex(@"" + c + @"\w*", RegexOptions.IgnoreCase);
                for (int i = 0; i < data.flats.Count(); i++)
                {
                    Match match = regex.Match(data.flats[i].adress.City);
                    if (match.Success)
                    {
                        result.Add(data.flats[i]);
                        Fill(data.flats[i]);
                    }
                }
            }
            else if (citys == null)
            {
                char f = floors[0];
                Regex regex = new Regex(@"" + f + @"\w*", RegexOptions.IgnoreCase);
                for (int i = 0; i < data.flats.Count(); i++)
                {
                    Match match = regex.Match(data.flats[i].Floor.ToString());
                    if (match.Success)
                    {
                        result.Add(data.flats[i]);
                        Fill(data.flats[i]);
                    }
                }
            }
            else
            {
                char c = citys[0];
                Regex regexC = new Regex(@"" + c + @"\w*", RegexOptions.IgnoreCase);
                char f = floors[0];
                Regex regexF = new Regex(@"" + f + @"\w*", RegexOptions.IgnoreCase);
                for (int i = 0; i < data.flats.Count(); i++)
                {
                    Match matchC = regexC.Match(data.flats[i].adress.City);
                    Match matchF = regexF.Match(data.flats[i].Floor.ToString());
                    if (matchC.Success && matchF.Success)
                    {
                        result.Add(data.flats[i]);
                        Fill(data.flats[i]);
                    }
                }
            }
        }

        private void Fill(Flat flat)
        {
            DataGridViewCell floor = new DataGridViewTextBoxCell();
            DataGridViewCell state = new DataGridViewTextBoxCell();
            DataGridViewCell city = new DataGridViewTextBoxCell();
            DataGridViewCell metrag = new DataGridViewTextBoxCell();

            floor.Value = flat.Floor;
            state.Value = flat.adress.State;
            city.Value = flat.adress.City;
            metrag.Value = flat.Metr;

            DataGridViewRow row = new DataGridViewRow();
            row.Cells.AddRange(floor, state, city, metrag);
            dataGridView1.Rows.Add(row);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
            data.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountOfRoomscheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
