using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                listBox1.Items.Clear();
                double num = 1;
                double c;
                do
                {
                    
                  c= Math.Round(System.Math.Sqrt(num),4);
                    listBox1.Items.Add(c);
                    num++;
                } while (num <= Convert.ToInt32(textBox1.Text));
               
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        
        }
    }
}
