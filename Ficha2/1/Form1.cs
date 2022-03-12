using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = (int)Math.Ceiling (Math.Sqrt(Convert.ToInt32(textBox1.Text))) ;
            label2.Text = "";
            for (int i = 2; i <= x; ++i)
            {
                if (Convert.ToInt32(textBox1.Text) % i == 0)
                { label2.Text = "Não é número primo."; }
                else { label2.Text = "Número primo."; }
                if (Convert.ToInt32(textBox1.Text) == 2)
                 {
                   label2.Text = "Número primo.";             
                 }                   
           }
        }
    }
}
