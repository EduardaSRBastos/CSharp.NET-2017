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
         
        
        private void button2_Click(object sender, EventArgs e)
        {
            string t1="", t2="", t3="",c1="",c2="";
            if (checkBox1.Checked == true)
            {
                t1 = checkBox1.Text +", ";
            }
            else { t1 = ""; }
            if (checkBox2.Checked == true)
            {
                t2 = checkBox2.Text + ", ";
            }
            else { t2 = ""; }
            if (checkBox3.Checked == true)
            {
                t3 = checkBox3.Text + ", ";
            }
            else { t3 = ""; }
            if (radioButton1.Checked == true)
            {
                c1 = radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                c2 = radioButton2.Text;
            }
            MessageBox.Show("Modelo escolhido: "+label1.Text +", Componentes adicionais: "+t1+t2+t3+"Cor escolhida: "+c1+c2) ;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {         
            if (radioButton2.Checked == true)
            {
                pictureBox1.BackgroundImage= Properties.Resources.Terminator_3;
                label1.Text = "Modelo Base - ASUS Terminator 3";
            }
            else
            {
                pictureBox1.BackgroundImage = Properties.Resources.Terminator_2;
                label1.Text = "Modelo Base - ASUS Terminator 2";
            }         
        }
public void ya()
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ya();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ya();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ya();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            checkBox1.Checked =false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            pictureBox1.BackgroundImage = Properties.Resources.Terminator_2;
            label1.Text = "Modelo Base - ASUS Terminator 2";
            radioButton1.Checked = true;
        }
    }
}
