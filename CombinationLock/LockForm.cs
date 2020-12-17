using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombinationLock
{

    public partial class LockForm : Form
    {
        private static string code = "123456";
        private static string settingscode = "678912";
        private static string security;
        private static byte misscount = 0;
        private static byte mistakes = 3;
        public static string Code { set { code = value; } }
        public static byte Mistakes { set { mistakes = value; } }
        public static string Security { set { security = value; } }
        SoundPlayer DoorOpen = new SoundPlayer(CombinationLock.Properties.Resources.open);
        SoundPlayer DoorLocked = new SoundPlayer(CombinationLock.Properties.Resources._lock);
        SoundPlayer Button = new SoundPlayer(CombinationLock.Properties.Resources.button);

        public LockForm()
        {
            InitializeComponent();
        }

        #region CodeButtons
        private void button1_Click(object sender, EventArgs e)
        {
            Button.Play();
            if (textBox1.TextLength<=code.Length-1)
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button.Play();
            if (textBox1.TextLength <= code.Length - 1)
                textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button.Play();
            if (textBox1.TextLength <= code.Length - 1)
                textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button.Play();
            if (textBox1.TextLength <= code.Length - 1)
                textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button.Play();
            if (textBox1.TextLength <= code.Length - 1)
                textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button.Play();
            if (textBox1.TextLength <= code.Length - 1)
                textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button.Play();
            if (textBox1.TextLength <= code.Length - 1)
                textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button.Play();
            if (textBox1.TextLength <= code.Length - 1)
                textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button.Play();
            if (textBox1.TextLength <= code.Length - 1)
                textBox1.Text += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button.Play();
            if (textBox1.TextLength <= code.Length - 1)
                textBox1.Text += 0;
        }
        #endregion

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Button.Play();
            if (textBox1.TextLength >= 1)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Button.Play();
            timer1.Start();
            if (textBox1.Text == settingscode)
            {
                ActiveForm.Hide();
                var sf = new SettingsForm();
                sf.Show(this);
            }
            else if (textBox1.Text == code) 
            { 
                BackColor = Color.LawnGreen;
                label1.Text = "Дверь открыта";
                DoorOpen.Play();
                misscount = 0;
                textBox1.Clear();
            }
            else if (misscount == mistakes-1)
            {
                BackColor = Color.OrangeRed;
                DoorLocked.Play();
                label1.Text = "Неверный код! Дверь заблокирована";
                label2.Text = "Передано сообщение охране";
                textBox1.Clear();
                #region Disable
                button0.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                buttonDelete.Enabled = false;
                buttonOK.Enabled = false;
                #endregion
            }
            else
            {
                misscount++;
                BackColor = Color.OrangeRed;
                DoorLocked.Play();
                label1.Text = "Неверный код! Осталось попыток: " + (mistakes-misscount);
                textBox1.Clear();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            label1.Text = "";
            label2.Text = "";
            textBox1.Clear();
            timer1.Stop();
        }
    }
}
