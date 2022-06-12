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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Input_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Input inpf = new Form_Input();
            inpf.Show();
        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Result calcr = new Form_Result();
            calcr.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Input inpf = new Form_Input();
            inpf.Show();
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Result calcr = new Form_Result();
            calcr.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
