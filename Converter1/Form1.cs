using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.ReadOnly = false;
                textBox1.Focus();
                textBox2.ReadOnly = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox2.ReadOnly = false;
                textBox2.Focus();
                textBox1.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    double f = double.Parse(textBox1.Text);
                    double c = (f - 32) * 5 / 9;
                    textBox2.Text = c.ToString("F");
                }
                else
                {
                    double c = double.Parse(textBox2.Text);
                    double f = 32 + c * 1.8;
                    textBox1.Text = f.ToString("F");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ошибка выполнения:\n{err.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
