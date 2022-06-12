using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14
{
    public partial class Form_Input : Form
    {
        public Form_Input()
        {
            InitializeComponent();
        }
        //контроль ввода tB_length_1
        private void tB_length_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
               e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (tB_length_1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button_save.Focus();
                return;
            }

            e.Handled = true;
        }
        //контроль ввода tB_length_2
        private void tB_length_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
               e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (tB_length_2.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button_save.Focus();
                return;
            }

            e.Handled = true;
        }
        //контроль ввода tB_length_3
        private void tB_length_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (tB_length_3.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button_save.Focus();
                return;
            }

            e.Handled = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if ((tB_length_1.Text.Equals("")) || (tB_length_2.Text.Equals("")) || (tB_length_3.Text.Equals("")))
            {
                MessageBox.Show("Вы ввели не все необходимые данные!!", "Внимание",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (!cB_Perimeter.Checked && !cB_Square.Checked)
                {
                    MessageBox.Show("Выберите хотя бы что-то одно для расчёта: периметр или площадь!!", "Внимание",
                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    Data.Len1 = double.Parse(tB_length_1.Text);
                    Data.Len2 = double.Parse(tB_length_2.Text);
                    Data.Len3 = double.Parse(tB_length_3.Text);

                    if (!IsExistTriangle(Data.Len1, Data.Len2, Data.Len3))
                    {
                        MessageBox.Show("Такого треугольника не может существовать! Введите новые длины сторон!", "Внимание",
                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        if (cB_Perimeter.Checked)
                        { 
                            Data.Per = Perimeter(Data.Len1, Data.Len2, Data.Len3);
                            Data.IsPer = true;
                        }

                        if (cB_Square.Checked)
                        {
                            Data.Sq = Area(Data.Len1, Data.Len2, Data.Len3);
                            Data.IsSq = true;
                        }
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                }
            }
        }
        private bool IsExistTriangle(double a, double b, double c)
        {
            if(a + b > c && a+c > b && b + c > a) { return true; }
            else { return false; }

        }
        private double Area(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            Data.Sq = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return Data.Sq;
        }
        private double Perimeter(double a, double b, double c)
        {
            Data.Per = a + b + c;

            return Data.Per;
        }
    }
}
