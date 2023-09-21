using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lojaABC
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {


            //Declarando variavel para receber o valor do butão
            DialogResult resp = MessageBox.Show("Deseja sair?", "Mensagem do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

            if(resp == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (resp == DialogResult.No)
            {
                Application.Exit();
            }
            if (resp == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0.0;

            try
            {
                num1 = Convert.ToDouble(txtVar1.Text);
                num2 = Convert.ToDouble(txtVar2.Text);

                if (rbtAdicao.Checked || rbtSubtracao.Checked || rbtMultiplicacao.Checked || rbtDivisao.Checked)
                {


                    if (rbtAdicao.Checked)
                    {
                        resultado = num1 + num2;
                    }
                    if (rbtSubtracao.Checked)
                    {
                        resultado = num1 - num2;
                    }
                    if (rbtDivisao.Checked)
                    {
                        if (num2 == 0)
                        {
                            MessageBox.Show("Impossivel dividir por zero", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        resultado = num1 / num2;
                    }
                    if (rbtMultiplicacao.Checked)
                    {
                        resultado = num1 * num2;
                    }

                    lblCalculo.Text = resultado.ToString();
                    limparCamposCalcular();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma operação", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, inserir somente números", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                limparCampos();
            }
        }

        //criando método para limpar conteúdo
        public void limparCamposCalcular()
        {
            txtVar1.Text = ""; //limpa caixa de texto
            txtVar2.Clear(); //limpa caixa de texto
            //limpando RadioButton
            rbtAdicao.Checked = false;
            rbtSubtracao.Checked = false;
            rbtMultiplicacao.Checked = false;
            rbtDivisao.Checked = false;

            txtVar1.Focus(); //Retornar o tabindex para ele
        }
        public void limparCampos()
        {
            txtVar1.Text = ""; //limpa caixa de texto
            txtVar2.Clear(); //limpa caixa de texto
            lblCalculo.Text = ""; //limpar label
            //limpando RadioButton
            rbtAdicao.Checked = false;
            rbtSubtracao.Checked = false;
            rbtMultiplicacao.Checked = false;
            rbtDivisao.Checked = false;

            txtVar1.Focus(); //Retornar o tabindex para ele
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //executar o metodo/função limparCampos
            limparCampos();
        }
    }
}
