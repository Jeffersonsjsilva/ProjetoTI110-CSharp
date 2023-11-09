
namespace lojaABC
{
    partial class frmCalcularGorjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalcularGorjeta));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValorConta = new System.Windows.Forms.Label();
            this.txtValorConta = new System.Windows.Forms.TextBox();
            this.lblAvaliacao = new System.Windows.Forms.Label();
            this.cbbAvaliacao = new System.Windows.Forms.ComboBox();
            this.btnCalcularGorjeta = new System.Windows.Forms.Button();
            this.txtValorGorjeta = new System.Windows.Forms.TextBox();
            this.lblValorGorjeta = new System.Windows.Forms.Label();
            this.cbbFuncionario = new System.Windows.Forms.ComboBox();
            this.lblSelecionarFuncionario = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtCodigoFunc = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodigoConta = new System.Windows.Forms.Label();
            this.txtCodigoConta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(243, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora de gorjeta";
            // 
            // lblValorConta
            // 
            this.lblValorConta.AutoSize = true;
            this.lblValorConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorConta.Location = new System.Drawing.Point(201, 191);
            this.lblValorConta.Name = "lblValorConta";
            this.lblValorConta.Size = new System.Drawing.Size(112, 20);
            this.lblValorConta.TabIndex = 1;
            this.lblValorConta.Text = "Valor da conta";
            // 
            // txtValorConta
            // 
            this.txtValorConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorConta.Location = new System.Drawing.Point(205, 227);
            this.txtValorConta.Name = "txtValorConta";
            this.txtValorConta.Size = new System.Drawing.Size(108, 26);
            this.txtValorConta.TabIndex = 4;
            // 
            // lblAvaliacao
            // 
            this.lblAvaliacao.AutoSize = true;
            this.lblAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaliacao.Location = new System.Drawing.Point(460, 84);
            this.lblAvaliacao.Name = "lblAvaliacao";
            this.lblAvaliacao.Size = new System.Drawing.Size(77, 20);
            this.lblAvaliacao.TabIndex = 3;
            this.lblAvaliacao.Text = "Avaliação";
            // 
            // cbbAvaliacao
            // 
            this.cbbAvaliacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAvaliacao.FormattingEnabled = true;
            this.cbbAvaliacao.ItemHeight = 20;
            this.cbbAvaliacao.Items.AddRange(new object[] {
            "Excelente - 10%",
            "Ótimo - 8%",
            "Bom - 5%",
            "Ruim - 2%"});
            this.cbbAvaliacao.Location = new System.Drawing.Point(441, 128);
            this.cbbAvaliacao.Name = "cbbAvaliacao";
            this.cbbAvaliacao.Size = new System.Drawing.Size(195, 28);
            this.cbbAvaliacao.TabIndex = 2;
            // 
            // btnCalcularGorjeta
            // 
            this.btnCalcularGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularGorjeta.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularGorjeta.Image")));
            this.btnCalcularGorjeta.Location = new System.Drawing.Point(8, 7);
            this.btnCalcularGorjeta.Name = "btnCalcularGorjeta";
            this.btnCalcularGorjeta.Size = new System.Drawing.Size(136, 76);
            this.btnCalcularGorjeta.TabIndex = 9;
            this.btnCalcularGorjeta.Text = "Calcular gorjeta";
            this.btnCalcularGorjeta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcularGorjeta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCalcularGorjeta.UseVisualStyleBackColor = true;
            this.btnCalcularGorjeta.Click += new System.EventHandler(this.btnCalcularGorjeta_Click);
            // 
            // txtValorGorjeta
            // 
            this.txtValorGorjeta.Enabled = false;
            this.txtValorGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorGorjeta.Location = new System.Drawing.Point(348, 227);
            this.txtValorGorjeta.Name = "txtValorGorjeta";
            this.txtValorGorjeta.Size = new System.Drawing.Size(117, 26);
            this.txtValorGorjeta.TabIndex = 5;
            // 
            // lblValorGorjeta
            // 
            this.lblValorGorjeta.AutoSize = true;
            this.lblValorGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorGorjeta.Location = new System.Drawing.Point(344, 191);
            this.lblValorGorjeta.Name = "lblValorGorjeta";
            this.lblValorGorjeta.Size = new System.Drawing.Size(121, 20);
            this.lblValorGorjeta.TabIndex = 6;
            this.lblValorGorjeta.Text = "Valor da gorjeta";
            // 
            // cbbFuncionario
            // 
            this.cbbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFuncionario.FormattingEnabled = true;
            this.cbbFuncionario.Location = new System.Drawing.Point(205, 128);
            this.cbbFuncionario.Name = "cbbFuncionario";
            this.cbbFuncionario.Size = new System.Drawing.Size(184, 28);
            this.cbbFuncionario.TabIndex = 1;
            this.cbbFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbbFuncionario_SelectedIndexChanged);
            // 
            // lblSelecionarFuncionario
            // 
            this.lblSelecionarFuncionario.AutoSize = true;
            this.lblSelecionarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarFuncionario.Location = new System.Drawing.Point(201, 94);
            this.lblSelecionarFuncionario.Name = "lblSelecionarFuncionario";
            this.lblSelecionarFuncionario.Size = new System.Drawing.Size(166, 20);
            this.lblSelecionarFuncionario.TabIndex = 8;
            this.lblSelecionarFuncionario.Text = "Selecionar funcionário";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(44, 338);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(142, 26);
            this.txtValorTotal.TabIndex = 7;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(40, 298);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(81, 20);
            this.lblValorTotal.TabIndex = 10;
            this.lblValorTotal.Text = "Valor total";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.Location = new System.Drawing.Point(150, 7);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(133, 76);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtCodigoFunc
            // 
            this.txtCodigoFunc.Enabled = false;
            this.txtCodigoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFunc.Location = new System.Drawing.Point(47, 128);
            this.txtCodigoFunc.Name = "txtCodigoFunc";
            this.txtCodigoFunc.Size = new System.Drawing.Size(47, 26);
            this.txtCodigoFunc.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(40, 94);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(124, 20);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "Cod. funcionário";
            // 
            // lblCodigoConta
            // 
            this.lblCodigoConta.AutoSize = true;
            this.lblCodigoConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoConta.Location = new System.Drawing.Point(38, 191);
            this.lblCodigoConta.Name = "lblCodigoConta";
            this.lblCodigoConta.Size = new System.Drawing.Size(86, 20);
            this.lblCodigoConta.TabIndex = 15;
            this.lblCodigoConta.Text = "Cod. conta";
            // 
            // txtCodigoConta
            // 
            this.txtCodigoConta.Enabled = false;
            this.txtCodigoConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoConta.Location = new System.Drawing.Point(47, 227);
            this.txtCodigoConta.Name = "txtCodigoConta";
            this.txtCodigoConta.Size = new System.Drawing.Size(47, 26);
            this.txtCodigoConta.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnCalcularGorjeta);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Location = new System.Drawing.Point(238, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 171);
            this.panel1.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(69, 89);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(136, 76);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar conta";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(289, 7);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(136, 76);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(243, 89);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(133, 76);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Voltar";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(523, 191);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 20);
            this.lblData.TabIndex = 16;
            this.lblData.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(510, 229);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(96, 20);
            this.dtpData.TabIndex = 6;
            // 
            // frmCalcularGorjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(692, 487);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCodigoConta);
            this.Controls.Add(this.txtCodigoConta);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigoFunc);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.cbbFuncionario);
            this.Controls.Add(this.lblSelecionarFuncionario);
            this.Controls.Add(this.txtValorGorjeta);
            this.Controls.Add(this.lblValorGorjeta);
            this.Controls.Add(this.cbbAvaliacao);
            this.Controls.Add(this.lblAvaliacao);
            this.Controls.Add(this.txtValorConta);
            this.Controls.Add(this.lblValorConta);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.Name = "frmCalcularGorjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalcularGorjeta";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValorConta;
        private System.Windows.Forms.TextBox txtValorConta;
        private System.Windows.Forms.Label lblAvaliacao;
        private System.Windows.Forms.ComboBox cbbAvaliacao;
        private System.Windows.Forms.Button btnCalcularGorjeta;
        private System.Windows.Forms.TextBox txtValorGorjeta;
        private System.Windows.Forms.Label lblValorGorjeta;
        private System.Windows.Forms.ComboBox cbbFuncionario;
        private System.Windows.Forms.Label lblSelecionarFuncionario;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtCodigoFunc;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodigoConta;
        private System.Windows.Forms.TextBox txtCodigoConta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}