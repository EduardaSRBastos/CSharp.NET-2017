using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstNumero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtLimite.Text, out parsedValue))
            {
                MessageBox.Show("Introduza apenas um numero");
                return;
            }
            else
            {
                if (rtbSequencial.Checked)
                {
                    lstNumero.Items.Clear();
                    int number=1;
                    int texto = Convert.ToInt32(txtLimite.Text);
                  /*  do
                    {
                        lstNumero.Items.Add(number);
                        number++;
                    } while (number <= Convert.ToInt32(txtLimite.Text));
                    number = 1;*/
                    for(number=1;number<= texto;number++)
                    {
                        lstNumero.Items.Add(number);
                    }
                } 
                else
                {
                    lstNumero.Items.Clear();
                    int number = 2;
                    do
                    {
                        lstNumero.Items.Add(number);
                        number = number + 2;
                    } while (number <= Convert.ToInt32(txtLimite.Text));
                    number = 2;
                }
            }
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
