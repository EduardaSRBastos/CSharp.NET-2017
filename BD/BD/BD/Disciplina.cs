using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.OleDb;

namespace BD
{
    class Disciplina
    {
        private int id, anoCurricular;
        private string disciplina, abreviatura;
        public void setID(int id)
        { this.id = id; }
        public int getid()
        { return id; }
        public void setDados(string p_disciplina, string p_abreviatura, int p_anoCurricular)
        { disciplina = p_disciplina; abreviatura = p_abreviatura; anoCurricular = p_anoCurricular; }
        public string getDisciplina()
        { return disciplina; }
        public string getAbreviatura()
        { return abreviatura; }
        public int AnoCurricular()
        { return anoCurricular; }
        public int Adiciona_BD(string conexao)
        {
            int status = 100;
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = conexao;
            OleDbCommand cmd = bd.CreateCommand();
            string strInsert = "INSERT INTO Disciplinas (Disciplina,Abreviatura,AnoCurricular) Values (";
            if (disciplina.Length > 0)
            { strInsert = strInsert + "'" + disciplina + "',"; }
            else { status = -1; }
            if (abreviatura.Length > 0)
            { strInsert = strInsert + "'" + abreviatura + "',"; }
            else { status = -2; }
            if (anoCurricular.ToString() != "")
            { strInsert = strInsert + anoCurricular.ToString() + ")"; }
            cmd.CommandText = strInsert;
            if (status == 100)
            {
                try
                {
                    bd.Open();
                    cmd.ExecuteNonQuery();
                    bd.Close();
                }
                catch (Exception erro)
                {
                    status = -200;
                }
            }
            return status;
        }
    }
}
