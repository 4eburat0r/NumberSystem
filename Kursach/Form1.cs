using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //функция проверки ввода данных в textbox
        bool checkInput(object sender, KeyPressEventArgs e, TextBox textBox)
        {
            if (rbHexaSys1.Checked == true || comboBox1.SelectedIndex == 3)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8 || ((e.KeyChar == 45) && (textBox.Text.Length == 0)) || 
                    (int)e.KeyChar == 44 || ((int)e.KeyChar >= 65 && (int)e.KeyChar <= 70) || ((int)e.KeyChar >= 97 && (int)e.KeyChar <= 102)))
                    return false;
                else return true;
            }
            else if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8 || ((e.KeyChar == 45) && (textBox.Text.Length == 0)) || (int)e.KeyChar == 44))
                return false;
            else return true;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkInput(sender, e, textBox1) == false) e.KeyChar = (char)0;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkInput(sender, e, textBox3) == false) e.KeyChar = (char)0;
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkInput(sender, e, textBox4) == false) e.KeyChar = (char)0;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.ReadOnly = true;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ReadOnly = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //десятичная в двоичную и обратно
            if (rbDecimalSys1.Checked == true && rbBinarySys2.Checked == true)
            {
                int decimalNumber = int.Parse(textBox1.Text);
                textBox2.Text = Convert.ToString(decimalNumber, 2);
            }
            if (rbBinarySys1.Checked == true && rbDecimalSys2.Checked == true)
            {
                int binaryNumber = Convert.ToInt32(textBox1.Text, 2);
                textBox2.Text = binaryNumber.ToString();
            }
            //двоичная в восьмиричную и обратно
            if (rbOctalSys1.Checked == true && rbBinarySys2.Checked == true)
            {
                int decimalValue = Convert.ToInt32(textBox1.Text, 8);
                textBox2.Text = Convert.ToString(decimalValue, 2);
            }
            if (rbBinarySys1.Checked == true && rbOctalSys2.Checked == true)
            {
                int decimalValue = Convert.ToInt32(textBox1.Text, 2);
                textBox2.Text = Convert.ToString(decimalValue, 8);
            }
            //двоичная в шестнадцатиричную и обратно
            if (rbHexaSys1.Checked == true && rbBinarySys2.Checked == true)
            {
                int decimalValue = Convert.ToInt32(textBox1.Text, 16);
                textBox2.Text = Convert.ToString(decimalValue, 2);
            }
            if (rbBinarySys1.Checked == true && rbHexaSys2.Checked == true)
            {
                int decimalValue = Convert.ToInt32(textBox1.Text, 2);
                textBox2.Text = Convert.ToString(decimalValue, 16);
            }

        }
        
    }
}
