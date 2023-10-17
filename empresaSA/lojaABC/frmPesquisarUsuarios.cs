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

namespace lojaABC
{
    public partial class frmPesquisarUsuarios : Form
    {
        public frmPesquisarUsuarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        //desabilitar campos
        public void desabilitarCampos()
        {
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;

            txtDescricao.Enabled = false;

            rdbCodigo.Checked = false;
            rdbNome.Checked = false;

        }//Habilitar campos
        public void habilitaCampos()
        {
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            txtDescricao.Enabled = true;
            txtDescricao.Focus();

        }

        //limpar campos
        public void limparCampos()
        {
            txtDescricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Enabled = false;
            //ltbPesquisar.Items.Clear();
            txtDescricao.Focus();
        }

        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                pesquisarCodigo(Convert.ToInt32(txtDescricao.Text));
            }
            if (rdbNome.Checked)
            {
                pesquisarNome(txtDescricao.Text);
            }
        }

        //pesquisar por nome
        public void pesquisarNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usuario from tbUsuarios where usuario like '%" + nome + "%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = conexao.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            ltbPesquisar.Items.Clear();

            while (DR.Read())
            {
                ltbPesquisar.Items.Add(DR.GetString(0));
            }

            conexao.fecharConexao();
        }
        //Pesquisar por código
        public void pesquisarCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usuario from tbusuarios where codUsu = @codUsu;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUsu", MySqlDbType.Int32).Value = codigo;

            comm.Connection = conexao.obterConexao();


            // carregando dados para objeto de tabela
            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();
            ltbPesquisar.Items.Clear();

            ltbPesquisar.Items.Add(DR.GetString(0));

            conexao.fecharConexao();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitaCampos();
            txtDescricao.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitaCampos();
            txtDescricao.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbPesquisar.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um item da lista.", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                string nome = ltbPesquisar.SelectedItem.ToString();
                frmCadastroUsuario abrir = new frmCadastroUsuario(nome);
                abrir.Show();
                this.Hide();
            }
        }
    }
}
