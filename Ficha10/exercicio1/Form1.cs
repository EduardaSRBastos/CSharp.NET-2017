using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtIntroduzir_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIntroduzir.Text = Convert.ToString(listBox1.SelectedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void btnAcrescenta_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtIntroduzir.Text);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtIntroduzir.Text = "";
        }

        private void btnInicia_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
