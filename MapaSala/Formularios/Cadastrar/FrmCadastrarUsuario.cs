﻿using MapaSala.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmCadastrarUsuario : Form
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

     
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Login = txtLogin.Text;
            u.Senha = txtLogin.Text;
            u.Ativo = chkAtivo.Checked;
            u.Inserir();
            MessageBox.Show("Sucesso", "Cadastrado com sucesso");
            Close();
        }
    }
}
