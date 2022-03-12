using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(textBox1.Text)>0)
            { label1.Text = "positivo"; }
            else if(Convert.ToInt32(textBox1.Text) < 0)
            { label1.Text = "negativo"; }
            else { { label1.Text = "nulo"; } }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=8 && (e.KeyChar != '-'))
            { e.Handled=true; }
        }
    }
}
