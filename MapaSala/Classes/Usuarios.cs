﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSala.Classes
{
    public class Usuarios
    {
        private SqlConnection Conexao =
            new SqlConnection(
                "Server=LS05MPF;Database=AULA_DS;User Id=sa; Password=admsasql");
        public int Login { get; set; }
        public int Senha { get; set; }
        public int Ativo { get; set; }

        public void Inserir()
        {
            Conexao.Open();
            string query = "Insert into Usuarios (Login, Senha, Ativo" +
            " Values (@login, @senha, @ativo ";
            SqlParameter parametro1 = new SqlParameter("@login", Login);
            SqlParameter parametro1 = new SqlParameter("@senha", Senha);
            SqlParameter parametro1 = new SqlParameter("@ativo", Ativo);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery(); ;
            Conexao.Close();


        }
    }
}
