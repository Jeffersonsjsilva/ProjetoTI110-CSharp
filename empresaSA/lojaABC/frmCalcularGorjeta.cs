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
    public partial class frmCalcularGorjeta : Form
    {
        public frmCalcularGorjeta()
        {
            InitializeComponent();
            carregarFuncionario();
            carregarCodigoConta();
            txtValorConta.Focus();
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
                cbbFuncionario.Items.Add(DR.GetString(0));
            }
            conexao.fecharConexao();
           
        }

        public void limparCampos()
        {
            cbbFuncionario.SelectedIndex = -1;
            cbbAvaliacao.SelectedIndex = -1;
            txtCodigoFunc.Clear();
            txtValorConta.Clear();
            txtValorGorjeta.Clear();
            txtValorTotal.Clear();
        }

        public int confirmarConta()
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "insert into tbConta(avaliacao, valorGorjeta, valorConta, valorTotal, data, codFunc) values (@avaliacao, @valorGorjeta, @ValorConta, @valorTotal, @data, @codFunc);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@avaliacao",MySqlDbType.VarChar, 100).Value = cbbAvaliacao.Text;
            comm.Parameters.Add("@valorGorjeta", MySqlDbType.Decimal, 9).Value = txtValorGorjeta.Text;
            comm.Parameters.Add("@valorConta", MySqlDbType.Decimal, 9).Value = txtValorConta.Text;
            comm.Parameters.Add("@valorTotal", MySqlDbType.Decimal, 9).Value = txtValorTotal.Text;
            comm.Parameters.Add("@data", MySqlDbType.Date).Value = Convert.ToDateTime(dtpData.Text);
            comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 100).Value = txtCodigoFunc.Text;
            

            comm.Connection = conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            conexao.fecharConexao();
            return res;
        }
        public void carregarCodigo(string nome)
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "select codFunc from tbFuncionarios where nome like '%"+nome+"%'";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = nome;

            comm.Connection = conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigoFunc.Text = DR.GetString(0);
            conexao.fecharConexao();
        }
        public void carregarCodigoConta()
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();

                comm.CommandText = "select codConta+1 from tbConta order by codConta desc;";
                comm.CommandType = CommandType.Text;

                comm.Connection = conexao.obterConexao();
                MySqlDataReader DR;
                DR = comm.ExecuteReader();
                DR.Read();
                txtCodigoConta.Text = Convert.ToString(DR.GetInt32(0));

                conexao.fecharConexao();
            }
            catch (Exception)
            {
                txtCodigoConta.Text = "1";
            }

        }

        public void calcularValores()
        {
            if (txtValorConta.Text == "")
            {
                MessageBox.Show("Por favor, digite o valor da conta", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Double valor = Convert.ToDouble(txtValorConta.Text);
                if (cbbAvaliacao.SelectedIndex == 0)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.10);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.10));
                }
                if (cbbAvaliacao.SelectedIndex == 1)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.08);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.08));
                }
                if (cbbAvaliacao.SelectedIndex == 2)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.05);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.05));
                }
                if (cbbAvaliacao.SelectedIndex == 3)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.02);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.02));
                }
                if (cbbAvaliacao.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecione uma avaliação", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnCalcularGorjeta_Click(object sender, EventArgs e)
        {
            calcularValores();
        }

        private void cbbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarCodigo(cbbFuncionario.Text);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cbbAvaliacao.SelectedIndex.Equals(-1) || cbbFuncionario.SelectedIndex.Equals(-1) || txtValorConta.Text.Equals("")|| txtValorGorjeta.Text.Equals("")||
                txtValorTotal.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher campo valor da conta", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(confirmarConta() == 1)
                {
                    MessageBox.Show("Conta confirmada!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao confirmar", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarConta abrir = new frmPesquisarConta();
            abrir.Show();
            this.Hide();
        }
    }
}
