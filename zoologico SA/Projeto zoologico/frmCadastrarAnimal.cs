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
            txtTipo.Enabled = false;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        //habilitar campos
        public void habilitarCampos()
        {
            txtIdade.Enabled = true;
            txtNome.Enabled = true;
            txtTipo.Enabled = true;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;

            txtNome.Focus();
        }

        //limpar campos

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtIdade.Clear();
            txtNome.Clear();
            txtTipo.Clear();
            txtNome.Focus();
        }

        public int cadastrarAnimal()
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "insert into tbAnimais(nome,tipo,idade) values(@nome,@tipo,@idade);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome",MySqlDbType.VarChar,  100).Value = txtNome.Text;
            comm.Parameters.Add("@tipo", MySqlDbType.VarChar, 100).Value = txtTipo.Text;
            comm.Parameters.Add("@idade", MySqlDbType.VarChar, 100).Value = Convert.ToInt32(txtIdade.Text);

            comm.Connection = conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            conexao.fecharConexao();

            return res;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void frmCadastrarAnimal_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtIdade.Text.Equals("")||txtNome.Text.Equals("")||txtTipo.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher campos!!!");
                txtNome.Focus();
            }
            else
            {
                if (cadastrarAnimal() == 1)
                {
                    MessageBox.Show("CADASTRADO COM SUCESSO!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
    }
}
