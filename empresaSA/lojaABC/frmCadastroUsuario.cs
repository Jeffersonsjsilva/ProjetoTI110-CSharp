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

namespace lojaABC
{
    public partial class frmCadastroUsuario : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCadastroUsuario()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        public frmCadastroUsuario(string nome)
        {
            desabilitarCampos();
            txtUsuario.Text = nome;
            carregarUsuarios(nome);
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        // Cadastro de usuarios
        public int cadastrarUsuarios(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios(usuario,senha,codFunc)values(@usuario,@senha,@codFunc);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 30).Value = txtUsuario.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 30).Value = txtSenha.Text;
            comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 30).Value = codFunc;

            comm.Connection = conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            conexao.fecharConexao();

            return res;
        }
        // carrega codigo usuario
        public void carregaCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codUsu+1 from tbUsuarios order by codUsu desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));


            conexao.fecharConexao();
        }

        //carrega funcionario sem usuarios
        public void carregaCodigoFuncionario(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc from tbfuncionarios where nome = @nome";
            comm.CommandType = CommandType.Text;



            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;



            comm.Connection = conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();



            txtCodFunc.Text = Convert.ToString(DR.GetString(0));
            conexao.fecharConexao();
        }

        //carregar usuarios
        public void carregarUsuarios(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usu.codusu, usu.usuario, usu.senha, func.codFunc from tbFuncionarios as func inner join tbUsuarios as usu on func.codFunc = usu.codFunc where func.nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            try
            {
                txtCodigo.Clear();
                txtUsuario.Text = DR.GetString(1);
                txtSenha.Text = DR.GetString(2);
                txtCodigo.Text = DR.GetString(0);

                txtCodFunc.Text = DR.GetInt32(3).ToString();

                btnCadastrar.Enabled = false;

                conexao.fecharConexao();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Funcionário não possui usuário.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                btnCadastrar.Enabled = true;
                txtUsuario.Clear();
                txtSenha.Clear();
                txtRepetirSenha.Clear();
                txtCodigo.Clear();
                txtCodFunc.Clear();
                txtUsuario.Focus();

                //carregar o código do funcionario sem usuario
                carregaCodigo();
                carregaCodigoFuncionario(lstFuncSemUsu.SelectedItem.ToString());
            }
        }

        //carregar funcionarios
        public void carregarFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios order by nome asc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            lstFuncSemUsu.Items.Clear();

            while (DR.Read())
            {
                lstFuncSemUsu.Items.Add(DR.GetString(0));
            }
            conexao.fecharConexao();
        }

        //alterar usuario

        public int alterarUsuario(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update into tbUsuarios set usuario = @usuario, senha = @senha where codusu = @codusu;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario",MySqlDbType.VarChar,30).Value = txtUsuario.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = txtSenha.Text;
            comm.Parameters.Add("@codUsu", MySqlDbType.VarChar, 10).Value = codigo;
            comm.Connection = conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            conexao.fecharConexao();

            return res;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(txtRepetirSenha.Text))
            {
                if (cadastrarUsuarios(Convert.ToInt32(txtCodFunc.Text)) == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    desabilitarCamposNovo();
                    limparCampos();

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }

            }
            else
            {
                MessageBox.Show("Senha não confere!!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtSenha.Clear();
                txtRepetirSenha.Clear();
                txtSenha.Focus();
            }

        }

        //habilitar campos
        public void desabilitarCampos()
        {
            //Campos
            txtCodigo.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtRepetirSenha.Enabled = false;
            //Botões
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

        }

        //desabilitar campos novo
        public void desabilitarCamposNovo()
        {
            //Campos
            txtCodigo.Enabled = false;
            txtUsuario.Enabled = false;
            txtRepetirSenha.Enabled = false;
            txtSenha.Enabled = false;

            //Botões
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

            btnNovo.Enabled = true;
            btnNovo.Focus();

        }
        //habilitar campos 
        public void habilitarCampos()
        {
            //campos
            txtCodigo.Enabled = false;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtRepetirSenha.Enabled = true;
            //botões
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

            txtUsuario.Focus();
        }
        // criando um método limpar
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtRepetirSenha.Clear();
            txtUsuario.Focus();
           
        }
        public void limparTudo()
        {
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtRepetirSenha.Clear();
            lstFuncSemUsu.Items.Clear();
            txtUsuario.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            carregarFuncionarios();
            habilitarCampos();
        }

        private void lstFuncSemUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = lstFuncSemUsu.SelectedItem.ToString();
            carregarUsuarios(nome);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTudo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (alterarUsuario(Convert.ToInt32(txtCodigo.Text)) == 1)
            {
                MessageBox.Show("Usuario alterado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                desabilitarCamposNovo();
                limparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao alterar", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarUsuarios abrir = new frmPesquisarUsuarios();
            abrir.Show();
            this.Hide();
        }
    }
}
