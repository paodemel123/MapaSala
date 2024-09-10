using MapaSala.DAO;
using Model.Entitidades;
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
    public partial class frmCursoDisciplinacs : Form
    {
        DisciplinaDAO disciplinaDAO = new DisciplinaDAO();
        CursoDAO cursoDAO = new CursoDAO();
        CursoDisplinaDAO dao = new CursoDisplinaDAO();

        private void AtualizarGrid(DataTable dados)
        {
            dtCursoDisciplina.DataSource = dados;
        }

        public frmCursoDisciplinacs()
        {
            InitializeComponent();

            cbDisciplinas.DataSource = disciplinaDAO.PreencherComboBox();
            cbDisciplinas.DisplayMember = "Nome";
            cbDisciplinas.ValueMember = "Id";

            cbxCursos.DataSource = cursoDAO.PreencherComboBox();
            cbxCursos.DisplayMember = "Nome";
            cbxCursos.ValueMember = "Id";

            AtualizarGrid(dao.ObterCursoDisciplina());
      
        }
        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {
            CursoDisplinaDAO cursoDisplinaDAO = new CursoDisplinaDAO();
            CursoDisciplinaEntidade entidade = new CursoDisciplinaEntidade();
            entidade.CursoId = Convert.ToInt32(cbxCursos.SelectedValue);
            entidade.Periodo = cbPeriodos.SelectedItem.ToString();
            cursoDisplinaDAO.Inserir(entidade);
            AtualizarGrid(dao.ObterCursoDisciplina());
        }


        }
    }
