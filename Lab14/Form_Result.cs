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
    public partial class Form_Result : Form
    {
        public Form_Result()
        {
            InitializeComponent();
            if (Data.IsPer)
            {
                label_Perimeter.Text = Data.Per.ToString();
            }
            else
            {
                label_Perimeter.Text = "-";
            }
            if (Data.IsSq)
            {
                label_Square.Text = Data.Sq.ToString();
            }
            else
            {
                label_Square.Text = "-";
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Data.IsPer = false;
            Data.IsSq = false;
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
