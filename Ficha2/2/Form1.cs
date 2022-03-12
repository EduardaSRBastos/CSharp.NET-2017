using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int segundos = Convert.ToInt32(textBox1.Text);
            double minutos=0;
            if (segundos < 60)
            {
                textBox2.Text = "0:0:" + textBox1.Text;
            }
            else if(segundos < 3600)
            {
                if(segundos % 2==0)
                {
                    minutos = segundos / 60;
                    textBox2.Text = "0:" + minutos;
                }
                else
                {
                   minutos= segundos / 60;
                    
                    Math.Round(minutos);
                    textBox2.Text = "0:" + minutos;
                   
                }
               
            }
        }
    }
}
