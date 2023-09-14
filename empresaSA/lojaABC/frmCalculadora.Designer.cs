
namespace lojaABC
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblVar1 = new System.Windows.Forms.Label();
            this.lblVar2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.txtVar1 = new System.Windows.Forms.TextBox();
            this.txtVar2 = new System.Windows.Forms.TextBox();
            this.gbxOperador = new System.Windows.Forms.GroupBox();
            this.rbtAdicao = new System.Windows.Forms.RadioButton();
            this.rbtSubtracao = new System.Windows.Forms.RadioButton();
            this.rbtMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rbtDivisao = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbxOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVar1
            // 
            this.lblVar1.AutoSize = true;
            this.lblVar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVar1.Location = new System.Drawing.Point(54, 55);
            this.lblVar1.Name = "lblVar1";
            this.lblVar1.Size = new System.Drawing.Size(78, 20);
            this.lblVar1.TabIndex = 0;
            this.lblVar1.Text = "Variável 1";
            // 
            // lblVar2
            // 
            this.lblVar2.AutoSize = true;
            this.lblVar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVar2.Location = new System.Drawing.Point(54, 110);
            this.lblVar2.Name = "lblVar2";
            this.lblVar2.Size = new System.Drawing.Size(78, 20);
            this.lblVar2.TabIndex = 1;
            this.lblVar2.Text = "Variável 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(611, 55);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // lblCalculo
            // 
            this.lblCalculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCalculo.Location = new System.Drawing.Point(615, 77);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(118, 46);
            this.lblCalculo.TabIndex = 3;
            this.lblCalculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVar1
            // 
            this.txtVar1.Location = new System.Drawing.Point(58, 77);
            this.txtVar1.Name = "txtVar1";
            this.txtVar1.Size = new System.Drawing.Size(100, 20);
            this.txtVar1.TabIndex = 0;
            // 
            // txtVar2
            // 
            this.txtVar2.Location = new System.Drawing.Point(58, 133);
            this.txtVar2.Name = "txtVar2";
            this.txtVar2.Size = new System.Drawing.Size(100, 20);
            this.txtVar2.TabIndex = 1;
            // 
            // gbxOperador
            // 
            this.gbxOperador.Controls.Add(this.rbtDivisao);
            this.gbxOperador.Controls.Add(this.rbtMultiplicacao);
            this.gbxOperador.Controls.Add(this.rbtSubtracao);
            this.gbxOperador.Controls.Add(this.rbtAdicao);
            this.gbxOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOperador.Location = new System.Drawing.Point(289, 55);
            this.gbxOperador.Name = "gbxOperador";
            this.gbxOperador.Size = new System.Drawing.Size(177, 146);
            this.gbxOperador.TabIndex = 2;
            this.gbxOperador.TabStop = false;
            this.gbxOperador.Text = "Operador";
            // 
            // rbtAdicao
            // 
            this.rbtAdicao.AutoSize = true;
            this.rbtAdicao.Location = new System.Drawing.Point(7, 41);
            this.rbtAdicao.Name = "rbtAdicao";
            this.rbtAdicao.Size = new System.Drawing.Size(99, 24);
            this.rbtAdicao.TabIndex = 3;
            this.rbtAdicao.TabStop = true;
            this.rbtAdicao.Text = "Adição (+)";
            this.rbtAdicao.UseVisualStyleBackColor = true;
            // 
            // rbtSubtracao
            // 
            this.rbtSubtracao.AutoSize = true;
            this.rbtSubtracao.Location = new System.Drawing.Point(7, 65);
            this.rbtSubtracao.Name = "rbtSubtracao";
            this.rbtSubtracao.Size = new System.Drawing.Size(120, 24);
            this.rbtSubtracao.TabIndex = 4;
            this.rbtSubtracao.TabStop = true;
            this.rbtSubtracao.Text = "Subtração (-)";
            this.rbtSubtracao.UseVisualStyleBackColor = true;
            // 
            // rbtMultiplicacao
            // 
            this.rbtMultiplicacao.AutoSize = true;
            this.rbtMultiplicacao.Location = new System.Drawing.Point(6, 89);
            this.rbtMultiplicacao.Name = "rbtMultiplicacao";
            this.rbtMultiplicacao.Size = new System.Drawing.Size(138, 24);
            this.rbtMultiplicacao.TabIndex = 5;
            this.rbtMultiplicacao.TabStop = true;
            this.rbtMultiplicacao.Text = "Multiplicação (*)";
            this.rbtMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rbtDivisao
            // 
            this.rbtDivisao.AutoSize = true;
            this.rbtDivisao.Location = new System.Drawing.Point(7, 113);
            this.rbtDivisao.Name = "rbtDivisao";
            this.rbtDivisao.Size = new System.Drawing.Size(96, 24);
            this.rbtDivisao.TabIndex = 6;
            this.rbtDivisao.TabStop = true;
            this.rbtDivisao.Text = "Divisão (/)";
            this.rbtDivisao.UseVisualStyleBackColor = true;
            this.rbtDivisao.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(316, 298);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 31);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(316, 344);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 29);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(316, 394);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 29);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbxOperador);
            this.Controls.Add(this.txtVar2);
            this.Controls.Add(this.txtVar1);
            this.Controls.Add(this.lblCalculo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblVar2);
            this.Controls.Add(this.lblVar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.Text = " ";
            this.gbxOperador.ResumeLayout(false);
            this.gbxOperador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVar1;
        private System.Windows.Forms.Label lblVar2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.TextBox txtVar1;
        private System.Windows.Forms.TextBox txtVar2;
        private System.Windows.Forms.GroupBox gbxOperador;
        private System.Windows.Forms.RadioButton rbtDivisao;
        private System.Windows.Forms.RadioButton rbtMultiplicacao;
        private System.Windows.Forms.RadioButton rbtSubtracao;
        private System.Windows.Forms.RadioButton rbtAdicao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}