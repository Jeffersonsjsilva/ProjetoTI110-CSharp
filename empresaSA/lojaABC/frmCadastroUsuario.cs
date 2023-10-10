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

        //carregar usuarios
        public void carregarUsuarios(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usu.usuario, usu.senha, func.codFunc from tbFuncionarios as func inner join tbUsuarios as usu on func.codFunc = usu.codFunc where func.nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            try
            {
                txtUsuario.Text = DR.GetString(0);
                txtSenha.Text = DR.GetString(1);

                txtCodFunc.Text = DR.GetInt32(2).ToString();

                conexao.fecharConexao();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Funcionário não possui usuário.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                txtUsuario.Clear();
                txtSenha.Clear();
                txtCodigo.Clear();
                txtCodFunc.Clear();
                txtUsuario.Focus();
                carregaCodigo();
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
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(txtRepetirSenha.Text))
            {
                if (cadastrarUsuarios(Convert.ToInt32(txtCodFunc.Text)) == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            carregarFuncionarios();
        }

        private void lstFuncSemUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = lstFuncSemUsu.SelectedItem.ToString();
            carregarUsuarios(nome);
        }
    }
}
