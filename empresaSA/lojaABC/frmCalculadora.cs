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
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0.0;

            num1 = Convert.ToDouble(txtVar1.Text);
            num2 = Convert.ToDouble(txtVar2.Text);
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
                resultado = num1 / num2;
            }
            if (rbtMultiplicacao.Checked)
            {
                resultado = num1 * num2;
            }

            lblCalculo.Text = resultado.ToString();
        }
    }
}
