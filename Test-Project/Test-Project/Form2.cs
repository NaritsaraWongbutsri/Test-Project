using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Project
{
    public partial class Form2 : Form
    {
        CurrencyConverter currencyConverter = new CurrencyConverter();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string bath = this.textBox1.Text;
                double Ibath = Convert.ToDouble(bath);
                currencyConverter.addBrunei(Ibath);

                double brunei = currencyConverter.getBrunei();
                textBox2.Text = brunei.ToString();

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = checkBox1.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox2.Text;
            }

            else
            {
                textBox2.Text = "";
            }
            if (checkBox2.Checked == true)
            {
                string bath = this.textBox1.Text;
                double Ibath = Convert.ToDouble(bath);
                currencyConverter.addCambodia(Ibath);

                double cambodia = currencyConverter.getCombodia();
                textBox3.Text = cambodia.ToString();

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = checkBox2.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox3.Text;
            }
            else
            {
                textBox3.Text = "";
            }
            if (checkBox3.Checked == true)
            {
                string bath = this.textBox1.Text;
                double Ibath = Convert.ToDouble(bath);
                currencyConverter.addIndonesia(Ibath);

                double indonesia = currencyConverter.getIndonesia();
                textBox4.Text = indonesia.ToString();

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = checkBox3.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox4.Text;
            }
            else
            {
                textBox4.Text = "";
            }
            if (checkBox4.Checked == true)
            {
                string bath = this.textBox1.Text;
                double Ibath = Convert.ToDouble(bath);
                currencyConverter.addLaos(Ibath);

                double laos = currencyConverter.getLaos();
                textBox5.Text = laos.ToString();

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = checkBox4.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox5.Text;
            }
            else
            {
                textBox5.Text = "";
            }
            if (checkBox5.Checked == true)
            {
                string bath = this.textBox1.Text;
                double Ibath = Convert.ToDouble(bath);
                currencyConverter.addMalaysia(Ibath);

                double malaysia = currencyConverter.getMalaysia();
                textBox6.Text = malaysia.ToString();

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = checkBox5.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox6.Text;
            }
            else
            {
                textBox6.Text = "";
            }

            if (checkBox6.Checked == true)

            {
                string bath = this.textBox1.Text;
                double Ibath = Convert.ToDouble(bath);
                currencyConverter.addMyanmar(Ibath);

                double myanmar = currencyConverter.getMyanmar();
                textBox7.Text = myanmar.ToString();

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = checkBox6.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox7.Text;
            }
            else
            {
                textBox7.Text = "";
            }
            if (checkBox7.Checked == true)
            {
                string bath = this.textBox1.Text;
                double Ibath = Convert.ToDouble(bath);
                currencyConverter.addPhilippines(Ibath);

                double philippines = currencyConverter.getPhilippines();
                textBox8.Text = philippines.ToString();

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = checkBox7.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox8.Text;
            }
            else
            {
                textBox8.Text = "";
            }
            if (checkBox8.Checked == true)
            {
                string bath = this.textBox1.Text;
                double Ibath = Convert.ToDouble(bath);
                currencyConverter.addSingapore(Ibath);

                double singapore = currencyConverter.getSingapore();
                textBox9.Text = singapore.ToString();

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = checkBox8.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox9.Text;
            }
            else
            {
                textBox9.Text = "";
            }
            if (checkBox9.Checked == true)
            {
                string bath = this.textBox1.Text;
                double Ibath = Convert.ToDouble(bath);
                currencyConverter.addVietnam(Ibath);

                double vietnam = currencyConverter.getVietnam();
                textBox10.Text = vietnam.ToString();

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = checkBox9.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox10.Text;
            }
            else
            {
                textBox10.Text = "";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                { outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ","; }
                            }
                            File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        { 
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

    }
}
