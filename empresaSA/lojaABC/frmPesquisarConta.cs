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
    public partial class frmPesquisarConta : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmPesquisarConta()
        {
            InitializeComponent();
            carregarFuncionario();
            desabilitarCampos();
        }
        public void limparCampos()
        {
            cbbFuncionarios.SelectedIndex = -1;
            lbbContas.Items.Clear();
            txtCodFunc.Clear();
            txtTotal.Clear();
            dtpDataInicio.Value = DateTime.Now;
            dtpDataFinal.Value = DateTime.Now;
        }
        public void desabilitarCampos()
        {
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
            dtpDataInicio.Enabled = false;
            dtpDataFinal.Enabled = false;
        }
        public void habilitarCampos()
        {
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            dtpDataInicio.Enabled = true;
            dtpDataFinal.Enabled = true;
        }
        public void carregarFuncionario()
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "select nome from tbFuncionarios;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Connection = conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            while (DR.Read())
            {
                cbbFuncionarios.Items.Add(DR.GetString(0));
            }
            conexao.fecharConexao();

        }
        public void carregarCodigo(string nome)
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "select codFunc from tbFuncionarios where nome like '%" + nome + "%'";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodFunc.Text = DR.GetString(0);
            conexao.fecharConexao();
        }
        public void carregarGorjeta(int codigo)
        {

            Decimal total = 0;

            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "select valorGorjeta, avaliacao, data from tbconta where codFunc = @codFunc and data between @dataInicio and @dataFinal;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codigo;
            comm.Parameters.Add("@dataInicio", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDataInicio.Text);
            comm.Parameters.Add("@dataFinal", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDataFinal.Text);

            comm.Connection = conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            lbbContas.Items.Clear();

            while (DR.Read())
            {
                lbbContas.Items.Add("R$ " + DR.GetString(0) + " - " + DR.GetString(1) +" - " + DR.GetString(2));
                total = total + Convert.ToDecimal(DR.GetString(0));
            }
            txtTotal.Text = "R$ " + Convert.ToString(total);

            conexao.fecharConexao();

        }

        private void frmPesquisarConta_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmCalcularGorjeta abrir = new frmCalcularGorjeta();
            abrir.Show();
            this.Hide();
        }

        private void cbbFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarCodigo(cbbFuncionarios.Text);
            habilitarCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarGorjeta(Convert.ToInt32(txtCodFunc.Text));
            if (lbbContas.Items.Count == 0)
            {
                MessageBox.Show("Funcionário não possui gorjetas neste dia", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
