using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            txtDescricao.Focus();
        }
        public void limparCampos()
        {
            txtDescricao.Clear();
            lbbResultado.Items.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbTipo.Checked = false;
            txtDescricao.Focus();
        }

        //pesquisar por nome
        public void pesquisarNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "select nome from tbanimais where nome like '%"+nome+"%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = nome;

            comm.Connection = conexao.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            lbbResultado.Items.Clear();

            while (DR.Read())
            {
                lbbResultado.Items.Add(DR.GetString(0));
            }

            conexao.fecharConexao();
        }

        //pesquisar por tipo
        public void pesquisarTipo(string tipo)
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "select nome from tbanimais where tipo like '%" + tipo + "%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@tipo", MySqlDbType.VarChar, 100).Value = tipo;

            comm.Connection = conexao.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            lbbResultado.Items.Clear();

            while (DR.Read())
            {
                lbbResultado.Items.Add(DR.GetString(0));
            }

            conexao.fecharConexao();
        }

        //pesquisar por código
        public void pesquisarCodigo()
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();

                comm.CommandText = "select nome from tbanimais where codAni = @codAni;";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@codAni", MySqlDbType.VarChar, 100).Value = txtDescricao.Text;

                comm.Connection = conexao.obterConexao();

                MySqlDataReader DR;

                DR = comm.ExecuteReader();
                DR.Read();
                lbbResultado.Items.Clear();

                lbbResultado.Items.Add(DR.GetString(0));
            }
            catch (Exception)
            {
                MessageBox.Show("Código não encontrado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conexao.fecharConexao();

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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Favor, preencher o campo descrição", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rdbCodigo.Checked)
                {
                    pesquisarCodigo();
                }
                if (rdbNome.Checked)
                {
                    pesquisarNome(txtDescricao.Text);
                }
                if (rdbTipo.Checked)
                {
                    pesquisarTipo(txtDescricao.Text);
                }
            }
            
        }

        private void lbbResultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbbResultado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um dos items da lista", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string nome = lbbResultado.SelectedItem.ToString();
                frmCadastrarAnimal abrir = new frmCadastrarAnimal(nome);
                abrir.Show();
                this.Hide();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }
    }
   

}
