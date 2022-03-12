using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(label2.Text);
            label2.Text = Convert.ToString(num + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(label2.Text);
            label2.Text = Convert.ToString(num - 1);
        }
    }
}
