using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int idx;

            for (int x = listBox1.SelectedIndices.Count - 1; x >= 0; x--)
            {
                idx = listBox1.SelectedIndices[x];      
                listBox1.Items.RemoveAt(idx);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aux = "";
            foreach (int s in listBox1.SelectedIndices)
            {
                aux = aux + "+" + listBox1.Items[s];
            }
         
            label4.Text = aux;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

