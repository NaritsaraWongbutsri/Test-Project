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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("บูรไน");
            comboBox1.Items.Add("กัมพูชา");
            comboBox1.Items.Add("อินโดนีเซีย");
            comboBox1.Items.Add("ลาว");
            comboBox1.Items.Add("มาเลเซีย");
            comboBox1.Items.Add("พม่า");
            comboBox1.Items.Add("ฟิลิปปินส์");
            comboBox1.Items.Add("สิงคโปร์");
            comboBox1.Items.Add("เวียดนาม");
            comboBox1.Items.Add("ประเทศไทย");
            comboBox2.Items.Add("บูรไน");
            comboBox2.Items.Add("กัมพูชา");
            comboBox2.Items.Add("อินโดนีเซีย");
            comboBox2.Items.Add("ลาว");
            comboBox2.Items.Add("มาเลเซีย");
            comboBox2.Items.Add("พม่า");
            comboBox2.Items.Add("ฟิลิปปินส์");
            comboBox2.Items.Add("สิงคโปร์");
            comboBox2.Items.Add("เวียดนาม");
            comboBox2.Items.Add("ประเทศไทย");
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("กรุณาเลือกประเทศ", "แจ้งเตือน");
                }
                else if (comboBox2.Text == "")
                {
                    MessageBox.Show("กรุณาเลือกประเทศ", "แจ้งเตือน");
                }
                else
                {
                    if (comboBox1.Text == "บูรไน")
                    {
                        double total, m = double.Parse(textBox1.Text);
                        total = (m / 2) * 24.2271;
                        textBox11.Text = total.ToString();

                    }
                    else if (comboBox1.Text == "กัมพูชา")
                    {
                        double total, m = double.Parse(textBox1.Text);
                        total = (m / 2) * 0.8254;
                        textBox11.Text = total.ToString();

                    }
                    else if (comboBox1.Text == "อินโดนีเซีย")
                    {
                        double total, m = double.Parse(textBox1.Text);
                        total = (m / 2) * 2.1769;
                        textBox11.Text = total.ToString();

                    }
                    else if (comboBox1.Text == "ลาว")
                    {
                        double total, m = double.Parse(textBox1.Text);
                        total = (m / 2) * 0.2887;
                        textBox11.Text = total.ToString();

                    }
                    else if (comboBox1.Text == "มาเลเซีย")
                    {
                        double total, m = double.Parse(textBox1.Text);
                        total = (m / 2) * 7.8108;
                        textBox11.Text = total.ToString();

                    }
                    else if (comboBox1.Text == "พม่า")
                    {
                        double total, m = double.Parse(textBox1.Text);
                        total = (m / 2) * 0.0187;
                        textBox11.Text = total.ToString();

                    }
                    else if (comboBox1.Text == "ฟิลิปปินส์")
                    {
                        double total, m = double.Parse(textBox1.Text);
                        total = (m / 2) * 0.6228;
                        textBox11.Text = total.ToString();

                    }
                    else if (comboBox1.Text == "สิงคโปร์")
                    {
                        double total, m = double.Parse(textBox1.Text);
                        total = (m / 2) * 24.3376;
                        textBox11.Text = total.ToString();

                    }
                    else if (comboBox1.Text == "เวียดนาม")
                    {
                        double total, m = double.Parse(textBox1.Text);
                        total = (m / 2) * 0.1458;
                        textBox11.Text = total.ToString();

                    }
                    else if (comboBox1.Text == "ไทย")
                    {
                        double total, m = double.Parse(textBox1.Text);
                        total = (m / 2) * 1.0000;
                        textBox11.Text = total.ToString();

                    }
                }


            }
        }

        private void buttonCurrency_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.Text = total.ToString();
            }
            else
            {
                textBox2.Text = "";
            }
            if (checkBox2.Checked == true)
            {
                textBox3.Text = total.ToString();
            }
            else
            {
                textBox3.Text = "";
            }
            if (checkBox3.Checked == true)
            {
                textBox4.Text = total.ToString();
            }
            else
            {
                textBox4.Text = "";
            }
            if (checkBox4.Checked == true)
            {
                textBox5.Text = total.ToString();
            }
            else
            {
                textBox5.Text = "";
            }
            if (checkBox5.Checked == true)
            {
                textBox6.Text = total.ToString();
            }
            else
            {
                textBox6.Text = "";
            }
            if (checkBox6.Checked == true)
            {
                textBox7.Text = total.ToString();
            }
            else
            {
                textBox7.Text = "";
            }
            if (checkBox7.Checked == true)
            {
                textBox8.Text = total.ToString();
            }
            else
            {
                textBox8.Text = "";
            }
            if (checkBox8.Checked == true)
            {
                textBox9.Text = total.ToString();
            }

            else
            {
                textBox9.Text = "";
            }
            if (checkBox9.Checked == true)
            {
                textBox10.Text = total.ToString();
            }
            else
            {
                textBox10.Text = "";
            }
        }
    }
}
