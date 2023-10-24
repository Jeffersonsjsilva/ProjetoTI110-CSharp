using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Projeto_zoologico
{
    public partial class frmCadastrarAnimal : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCadastrarAnimal()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        public frmCadastrarAnimal(string nome)
        {
            InitializeComponent();
            desabilitarCamposNovo();
            txtNome.Text = nome;
            carregarAnimais(nome);
            cbbTipos.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // desabilitar campos 

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtIdade.Enabled = false;
            txtNome.Enabled = false;
            cbbTipos.Enabled = false;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }
        public void desabilitarCamposNovo()
        {
            txtCodigo.Enabled = false;

            btnNovo.Enabled = false;
            btnCadastrar.Enabled = false;
            btnLimpar.Enabled = true;
        }

        //habilitar campos
        public void habilitarCampos()
        {
            txtIdade.Enabled = true;
            txtNome.Enabled = true;
            cbbTipos.Enabled = true;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;

            txtNome.Focus();
        }
        
        public void habilitarCamposAlterar()
        {
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            txtNome.Focus();
        }

        public void habilitarCamposExcluir()
        {
            txtIdade.Enabled = false;
            txtNome.Enabled = false;
            cbbTipos.Enabled = false;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSair.Enabled = true;
        }
        //limpar campos

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtIdade.Clear();
            txtNome.Clear();
            cbbTipos.SelectedIndex = -1;
            txtNome.Focus();
        }

        public int cadastrarAnimal()
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "insert into tbAnimais(nome,tipo,idade) values(@nome,@tipo,@idade);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome",MySqlDbType.VarChar,  100).Value = txtNome.Text;
            comm.Parameters.Add("@tipo", MySqlDbType.VarChar, 100).Value = cbbTipos.Text;
            comm.Parameters.Add("@idade", MySqlDbType.VarChar, 100).Value = Convert.ToInt32(txtIdade.Text);

            comm.Connection = conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            conexao.fecharConexao();

            return res;

        }

        public void carregarAnimais(string nome)
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "select * from tbanimais where nome = @nome";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar, 100).Value = nome;
            comm.Connection = conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            txtNome.Text = DR.GetString(1);
            cbbTipos.Text = DR.GetString(2);
            txtIdade.Text = Convert.ToString(DR.GetString(3));

            conexao.fecharConexao();
        }
        public int alterarAnimais(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "UPDATE tbanimais set nome = @nome, tipo = @tipo, idade = @idade where codAni = @codAni;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value =txtNome.Text;
            comm.Parameters.Add("@tipo", MySqlDbType.VarChar, 100).Value = cbbTipos.Text;
            comm.Parameters.Add("@idade", MySqlDbType.VarChar, 100).Value = Convert.ToInt32(txtIdade.Text);
            comm.Parameters.Add("@codAni", MySqlDbType.Int32).Value = codigo;

            comm.Connection = conexao.obterConexao();

            int res = comm.ExecuteNonQuery();
            conexao.fecharConexao();

            return res;
        }

        public void carregarCodigo()
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select codAni+1 from tbAnimais order by codAni desc;";
                comm.CommandType = CommandType.Text;

                comm.Connection = conexao.obterConexao();

                MySqlDataReader DR;

                DR = comm.ExecuteReader();
                DR.Read();

                txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            }
            catch (Exception)
            {
                txtCodigo.Text = "1";
             
            }

            conexao.fecharConexao();

        }

        public void deletarAnimal(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbanimais where codani = @codani;";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@codani", MySqlDbType.Int32).Value = codigo;
            comm.Connection = conexao.obterConexao();

            comm.ExecuteNonQuery();
            conexao.fecharConexao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            carregarCodigo();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            carregarCodigo();
            habilitarCampos();
        }

        private void frmCadastrarAnimal_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtIdade.Text.Equals("")||txtNome.Text.Equals("")||cbbTipos.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher campos!","Mensagem do sistema", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else
            {
                if (cadastrarAnimal() == 1)
                {
                    MessageBox.Show("CADASTRADO COM SUCESSO!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    desabilitarCampos();
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarAnimal abrir = new frmPesquisarAnimal();
            abrir.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (alterarAnimais(Convert.ToInt32(txtCodigo.Text)) == 1)
            {
                MessageBox.Show("Alterado com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                habilitarCamposAlterar();
                carregarCodigo();
            }
            else
            {
                MessageBox.Show("Erro ao alterar", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
                desabilitarCampos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja excluir?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (resp == DialogResult.OK)
            {
                deletarAnimal(Convert.ToInt32(txtCodigo.Text));
                MessageBox.Show("Excluido com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                habilitarCamposExcluir();
            }
            else
            {

            }
        }
    }
}
