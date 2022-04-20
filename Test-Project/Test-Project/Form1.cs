namespace Test_Project
{
    public partial class Form1 : Form
    {
        int b2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Naritsara" || textBox2.Text != "2002")
            {
                MessageBox.Show("User และ Password ผิด!!", "รหัสผ่านผิด");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                b2++;
                if (b2 == 3)
                {
                    MessageBox.Show("User และ Password ผิด!! เกิน 3 ครั้งกรุณาออกจากโปรแกรม", "รหัสผ่านผิดเกิน 3 ครั้ง");
                    this.Close();
                }
            }
            else
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ยืนยันการออกจากโปรแกรม", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}