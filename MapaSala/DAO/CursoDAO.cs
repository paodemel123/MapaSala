﻿using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSala.DAO
{
    public class CursoDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao; 

        public CursoDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(cursoEntidades curso)
        {
            Conexao.Open();
            string query = "insert into Cursos(Nome, Turno,Sigla, Ativo) Values (@nome, @turno,@sigla,@ativo)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro2 = new SqlParameter("@nome", curso.Nome);
            SqlParameter parametro3 = new SqlParameter("@turno", curso.Turno);
            SqlParameter parametro4 = new SqlParameter("@sigla", curso.Sigla);
            SqlParameter parametro5 = new SqlParameter("@ativo", curso.Ativo);

            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);
            comando.ExecuteNonQuery(); 
            Conexao.Close();
        }
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Id, Nome FROM Cursos";

            using (SqlConnection connection = new SqlConnection(LinhaConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception("Erro ao acessar os dados: " + ex.Message);
                }
            }

            return dataTable;
        }

        public DataTable ObterCurso()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, Turno,Sigla, Ativo FROM CURSOS ORDER BY Id desc";
            SqlCommand Comando = new SqlCommand(query, Conexao);


            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(cursoEntidades).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows) 
            {
                while (Leitura.Read())
                {
                    cursoEntidades curso = new cursoEntidades();
                    curso.Id = Convert.ToInt32(Leitura[0]);
                    curso.Nome = Leitura[1].ToString();
                    curso.Turno = Leitura[2].ToString();
                    curso.Sigla = Leitura[3].ToString();
                    curso.Ativo = Convert.ToBoolean(Leitura[4]);
                    dt.Rows.Add(curso.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
        public DataTable Pesquisar(string pesquisa)
        {
            DataTable dt = new DataTable();
            Conexao.Open();

            string query = "";
            if (string.IsNullOrEmpty(pesquisa))
            {
                query = "SELECT Id, Nome, Turno,Sigla, Ativo FROM Cursos ORDER BY ID desc";
            }
            else
            {
                query = "SELECT Id, Nome, Turno, Sigla, Ativo FROM Cursos WHERE NOME LIKE '%" + pesquisa + "%' ORDER BY ID desc"; 
            }

            SqlCommand Comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(cursoEntidades).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows) 
            {
                while (Leitura.Read())
                {
                    cursoEntidades curso = new cursoEntidades();
                    curso.Id = Convert.ToInt32(Leitura[0]);
                    curso.Nome = Leitura[1].ToString();
                    curso.Turno = Leitura[2].ToString();
                    curso.Sigla = Leitura[3].ToString();
                    curso.Ativo = Convert.ToBoolean(Leitura[4]);
                    dt.Rows.Add(curso.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}