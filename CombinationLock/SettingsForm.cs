using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombinationLock
{
    public partial class SettingsForm : Form
    {
        static byte nowChanging;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nowChanging = 1;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            button6.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            nowChanging = 2;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            button6.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            nowChanging = 3;
            groupBox1.Visible = true;
            button6.Visible = true;
            groupBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (nowChanging == 1)
            {
                LockForm.Code = textBox1.Text;
                textBox1.Clear();
                MessageBox.Show("Код доступа успешно изменён");
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
            if (nowChanging == 2)
            {
                LockForm.Mistakes = Convert.ToByte(textBox1.Text);
                textBox1.Clear();
                MessageBox.Show("Допустимое количество неверных попыток успешно изменено");
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
            if (nowChanging == 3)
            {
                LockForm.Security = textBox1.Text;
                textBox1.Clear();
                MessageBox.Show("Заявка на смену охранной компании успешно отправлена");
                groupBox1.Visible = false;
                button6.Visible = false;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            LockForm lf = (LockForm)this.Owner;
            lf.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\WinSxS\amd64_microsoft-windows-osk_31bf3856ad364e35_10.0.19041.1_none_60ade0eff94c37fc\osk.exe");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength >= 1)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }
    }
}
