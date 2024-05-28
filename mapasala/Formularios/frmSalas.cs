using Model.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mapasala.Formularios
{
    public partial class frmSalas : Form
    {
        BlindingSource dados;
        public frmSalas()
        {
            InitializeComponent();
            dados = new BlindingSource();
            dtGridSalas.DataSource = dados;
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            SalasEntidade sala = new SalasEntidade();
            sala.Id = Convert.ToInt32(Id.Text);
            sala.Nome = NomeSalas.Text;
            sala.Islab = islab.Checked;
            sala.NumeroCadeiras = Convert.ToInt32(NumCadei.Value);
            sala.Numerocomputadores = Convert.ToInt32(NumComputadores.Value);
            sala.Disponivel = Disponivel.Checked;
            dados.Add(sala);


        }

        private void isDisp_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
