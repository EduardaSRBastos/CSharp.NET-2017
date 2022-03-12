using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strProvider;
            int resultado;
            Disciplina oDisciplina = new Disciplina();
            strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\(☞ﾟヮﾟ)☞ school  ☜(ﾟヮﾟ☜)\\11ºAno\\TP\\Exercícios\\Form\\BD\\Disciplinas.accdb;Persist Security Info=False";
            if (txtDisciplina.Text == "")
            { MessageBox.Show("Dado Obrigatório", "Erro", MessageBoxButtons.OK);
                txtDisciplina.Focus();
                return; }
            if (txtAbreviatura.Text == "")
            { MessageBox.Show("Dado Obrigatório", "Erro", MessageBoxButtons.OK);
                txtAbreviatura.Focus();
                return; }
            if (cbxAnoCurricular.Text == "")
            { MessageBox.Show("Dado Obrigatório", "Erro", MessageBoxButtons.OK);
                cbxAnoCurricular.Focus();
                return; }
            oDisciplina.setDados(txtDisciplina.Text, txtAbreviatura.Text, Convert.ToInt32(cbxAnoCurricular.Text));
            resultado = oDisciplina.Adiciona_BD(strProvider);
            if (resultado == 100)
            { MessageBox.Show("Registo adicionado com sucesso!");
                txtAbreviatura.Clear();
                txtDisciplina.Clear();
                cbxAnoCurricular.SelectedIndex = -1; }
            else MessageBox.Show("Erro " + resultado.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisciplina.Text = "";
            cbxAnoCurricular.Text = "";
            txtAbreviatura.Text = "";


        }
    }
    
}
