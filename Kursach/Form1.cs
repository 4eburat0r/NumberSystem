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
        //функция проверки ввода данных в textbox для перевода чисел
        bool checkInput1(object sender, KeyPressEventArgs e, TextBox textBox)
        {
            if (rbBinarySys1.Checked == true)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '1' || (int)e.KeyChar == 8 ))
                    return false;
                else return true;
            }
            if (rbOctalSys1.Checked == true)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '7' || (int)e.KeyChar == 8 ))
                    return false;
                else return true;
            }
            if (rbDecimalSys1.Checked == true)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8 ))
                    return false;
                else return true;
            }
            if (rbHexaSys1.Checked == true)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8
                || ((int)e.KeyChar >= 65 && (int)e.KeyChar <= 70)))
                    return false;
                else return true;
            }
            else return false;
        }
        //функция проверки ввода данных в textbox для проведения математических операций
        bool checkInput2(object sender, KeyPressEventArgs e, TextBox textBox)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '1' || (int)e.KeyChar == 8 ))
                    return false;
                else return true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '7' || (int)e.KeyChar == 8 ))
                    return false;
                else return true;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8 ))
                    return false;
                else return true;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8
                || ((int)e.KeyChar >= 65 && (int)e.KeyChar <= 70)))
                    return false;
                else return true;
            }
            else return false;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkInput1(sender, e, textBox1) == false) e.KeyChar = (char)0;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkInput2(sender, e, textBox3) == false) e.KeyChar = (char)0;
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkInput2(sender, e, textBox4) == false) e.KeyChar = (char)0;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.ReadOnly = true;
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox5.ReadOnly = true;
        }
        char[] cHexa = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };
        int[] iHexaNumeric = new int[] { 10, 11, 12, 13, 14, 15 };
        int[] iHexaIndices = new int[] { 0, 1, 2, 3, 4, 5 };
        string DecimalToBase(int iDec, int numbase)
        {
            string strBin = "";
            int[] result = new int[32];
            int MaxBit = 32;
            while(iDec > 0)
            {
                int rem = iDec % numbase;
                result[--MaxBit] = rem;
                iDec /= numbase;
            }
            for (int i = 0; i < result.Length; i++)
                if (result[i] >= 10)
                    strBin += cHexa[result[i] % 10];  
                else
                    strBin += result[i];
            strBin = strBin.TrimStart(new char[] { '0' });
            return strBin;
        }
        int BaseToDecimal(string sBase, int numbase)
        {
            int dec = 0;
            int b;
            int iProduct = 1;
            string sHexa = "";
            if (numbase > 10)
                for (int i = 0; i < cHexa.Length; i++)
                    sHexa += cHexa[i].ToString();
            for (int i = sBase.Length - 1; i >= 0; i--, iProduct *= numbase)
            {
                string sValue = sBase[i].ToString();
                if (sValue.IndexOfAny(cHexa) >= 0)
                    b = iHexaNumeric[sHexa.IndexOf(sBase[i])];
                else
                    b = (int)sBase[i] - 48;
                dec += (b * iProduct);
            }
            return dec;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //---ОПЕРАЦИИ ПЕРЕВОДА--- 
                //десятичная в двоичную и обратно
                if (rbDecimalSys1.Checked == true && rbBinarySys2.Checked == true)
                    textBox2.Text = DecimalToBase(Int32.Parse(textBox1.Text), 2);

                if (rbBinarySys1.Checked == true && rbDecimalSys2.Checked == true)
                    textBox2.Text = Convert.ToString(BaseToDecimal(textBox1.Text.ToString(), 2));
                //двоичная в восьмиричную и обратно
                if (rbOctalSys1.Checked == true && rbBinarySys2.Checked == true)
                {
                    int octalValue = Convert.ToInt32(textBox1.Text, 8);
                    textBox2.Text = Convert.ToString(octalValue, 2);
                }
                if (rbBinarySys1.Checked == true && rbOctalSys2.Checked == true)
                {
                    int binaryValue = Convert.ToInt32(textBox1.Text, 2);
                    textBox2.Text = Convert.ToString(binaryValue, 8);
                }
                //двоичная в шестнадцатиричную и обратно
                if (rbHexaSys1.Checked == true && rbBinarySys2.Checked == true)
                {
                    int hexaValue = Convert.ToInt32(textBox1.Text, 16);
                    textBox2.Text = Convert.ToString(hexaValue, 2);
                }
                if (rbBinarySys1.Checked == true && rbHexaSys2.Checked == true)
                {
                    int binaryValue = Convert.ToInt32(textBox1.Text, 2);
                    textBox2.Text = Convert.ToString(binaryValue, 16);
                }
                //восьмиричная в десятичную и обратно
                if (rbOctalSys1.Checked == true && rbDecimalSys2.Checked == true)
                    textBox2.Text = Convert.ToString(BaseToDecimal(textBox1.Text.ToString(), 8));

                if (rbDecimalSys1.Checked == true && rbOctalSys2.Checked == true)
                    textBox2.Text = DecimalToBase(Int32.Parse(textBox1.Text), 8);
                //восьмиричная в шестнадцатиричную и обратно
                if (rbOctalSys1.Checked == true && rbHexaSys2.Checked == true)
                {
                    int octalValue = Convert.ToInt32(textBox1.Text, 8);
                    textBox2.Text = Convert.ToString(octalValue, 16);
                }
                if (rbHexaSys1.Checked == true && rbOctalSys2.Checked == true)
                {
                    int hexaValue = Convert.ToInt32(textBox1.Text, 16);
                    textBox2.Text = Convert.ToString(hexaValue, 8);
                }
                //десятичная в шестнадцатиричную и обратно
                if (rbDecimalSys1.Checked == true && rbHexaSys2.Checked == true)
                    textBox2.Text = DecimalToBase(Int32.Parse(textBox1.Text), 16);

                if (rbHexaSys1.Checked == true && rbDecimalSys2.Checked == true)
                    textBox2.Text = Convert.ToString(BaseToDecimal(textBox1.Text.ToString(), 16));
                //---ПРОВЕДЕНИЕ МАТЕМАТИЧЕСКИХ ОПЕРАЦИЙ---
                //СЛОЖЕНИЕ
                //сложение двоичных чисел
                if (rbSum.Checked == true && comboBox1.SelectedIndex == 0)
                {
                    int binaryValue1 = Convert.ToInt32(textBox3.Text, 2);
                    int binaryValue2 = Convert.ToInt32(textBox4.Text, 2);
                    textBox5.Text = Convert.ToString(binaryValue1 + binaryValue2, 2);
                }
                //сложение восьмиричных чисел
                if (rbSum.Checked == true && comboBox1.SelectedIndex == 1)
                {
                    int octalValue1 = Convert.ToInt32(textBox3.Text, 8);
                    int octalValue2 = Convert.ToInt32(textBox4.Text, 8);
                    textBox5.Text = Convert.ToString(octalValue1 + octalValue2, 8);
                }
                //сложение десятичных чисел
                if (rbSum.Checked == true && comboBox1.SelectedIndex == 2)
                {
                    int decimalValue1 = Convert.ToInt32(textBox3.Text, 10);
                    int decimalValue2 = Convert.ToInt32(textBox4.Text, 10);
                    textBox5.Text = Convert.ToString(decimalValue1 + decimalValue2, 10);
                }
                //сложение шестнадцатиричных чисел
                if (rbSum.Checked == true && comboBox1.SelectedIndex == 3)
                {
                    int hexalValue1 = Convert.ToInt32(textBox3.Text, 16);
                    int hexalValue2 = Convert.ToInt32(textBox4.Text, 16);
                    textBox5.Text = Convert.ToString(hexalValue1 + hexalValue2, 16);
                }
                //ВЫЧИТАНИЕ
                //вычитание двоичных чисел
                if (rbMinus.Checked == true && comboBox1.SelectedIndex == 0)
                {
                    int binaryValue1 = Convert.ToInt32(textBox3.Text, 2);
                    int binaryValue2 = Convert.ToInt32(textBox4.Text, 2);
                    textBox5.Text = Convert.ToString(binaryValue1 - binaryValue2, 2);
                }
                //вычитание восьмиричных чисел
                if (rbMinus.Checked == true && comboBox1.SelectedIndex == 1)
                {
                    int octalValue1 = Convert.ToInt32(textBox3.Text, 8);
                    int octalValue2 = Convert.ToInt32(textBox4.Text, 8);
                    textBox5.Text = Convert.ToString(octalValue1 - octalValue2, 8);
                }
                //вычитание десятичных чисел
                if (rbMinus.Checked == true && comboBox1.SelectedIndex == 2)
                {
                    int decimalValue1 = Convert.ToInt32(textBox3.Text, 10);
                    int decimalValue2 = Convert.ToInt32(textBox4.Text, 10);
                    textBox5.Text = Convert.ToString(decimalValue1 - decimalValue2, 10);
                }
                //вычитание шестнадцатиричных чисел
                if (rbMinus.Checked == true && comboBox1.SelectedIndex == 3)
                {
                    int hexalValue1 = Convert.ToInt32(textBox3.Text, 16);
                    int hexalValue2 = Convert.ToInt32(textBox4.Text, 16);
                    textBox5.Text = Convert.ToString(hexalValue1 - hexalValue2, 16);
                }
                //УМНОЖЕНИЕ
                //умножение двоичных чисел
                if (rbMultiply.Checked == true && comboBox1.SelectedIndex == 0)
                {
                    int binaryValue1 = Convert.ToInt32(textBox3.Text, 2);
                    int binaryValue2 = Convert.ToInt32(textBox4.Text, 2);
                    textBox5.Text = Convert.ToString(binaryValue1 * binaryValue2, 2);
                }
                //умножение восьмиричных чисел
                if (rbMultiply.Checked == true && comboBox1.SelectedIndex == 1)
                {
                    int octalValue1 = Convert.ToInt32(textBox3.Text, 8);
                    int octalValue2 = Convert.ToInt32(textBox4.Text, 8);
                    textBox5.Text = Convert.ToString(octalValue1 * octalValue2, 8);
                }
                //умножение десятичных чисел
                if (rbMultiply.Checked == true && comboBox1.SelectedIndex == 2)
                {
                    int decimalValue1 = Convert.ToInt32(textBox3.Text, 10);
                    int decimalValue2 = Convert.ToInt32(textBox4.Text, 10);
                    textBox5.Text = Convert.ToString(decimalValue1 * decimalValue2, 10);
                }
                //умножение шестнадцатиричных чисел
                if (rbMultiply.Checked == true && comboBox1.SelectedIndex == 3)
                {
                    int hexalValue1 = Convert.ToInt32(textBox3.Text, 16);
                    int hexalValue2 = Convert.ToInt32(textBox4.Text, 16);
                    textBox5.Text = Convert.ToString(hexalValue1 * hexalValue2, 16);
                }
                //ДЕЛЕНИЕ   
                //деление двоичных чисел
                if (rbDevide.Checked == true && comboBox1.SelectedIndex == 0)
                {
                    int binaryValue1 = Convert.ToInt32(textBox3.Text, 2);
                    int binaryValue2 = Convert.ToInt32(textBox4.Text, 2);
                    textBox5.Text = Convert.ToString(binaryValue1 / binaryValue2, 2);
                }
                //деление восьмиричных чисел
                if (rbDevide.Checked == true && comboBox1.SelectedIndex == 1)
                {
                    int octalValue1 = Convert.ToInt32(textBox3.Text, 8);
                    int octalValue2 = Convert.ToInt32(textBox4.Text, 8);
                    textBox5.Text = Convert.ToString(octalValue1 / octalValue2, 8);
                }
                // Деление десятичных чисел с типом данных double
                if (rbDevide.Checked && comboBox1.SelectedIndex == 2)
                {
                    double decimalValue1 = Convert.ToDouble(textBox3.Text);
                    double decimalValue2 = Convert.ToDouble(textBox4.Text);
                    textBox5.Text = Convert.ToString(decimalValue1 / decimalValue2);
                }
                //деление шестнадцатиричных чисел
                if (rbDevide.Checked == true && comboBox1.SelectedIndex == 3)
                {
                    int hexalValue1 = Convert.ToInt32(textBox3.Text, 16);
                    int hexalValue2 = Convert.ToInt32(textBox4.Text, 16);
                    textBox5.Text = Convert.ToString(hexalValue1 / hexalValue2, 16);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
