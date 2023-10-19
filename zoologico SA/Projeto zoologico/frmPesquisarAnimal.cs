using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_zoologico
{
    public partial class frmPesquisarAnimal : Form
    {
        public frmPesquisarAnimal()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public void desabilitarCampos()
        {
            txtDescricao.Enabled = false;
            btnLimpar.Enabled = false;
            btnPesquisar.Enabled = false;
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbTipo.Checked = false;
        }
        public void habilitarCampos()
        {
            txtDescricao.Enabled = true;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void rdbTipo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmCadastrarAnimal abrir = new frmCadastrarAnimal();
            abrir.Show();
            this.Close();
        }
    }
   

}
