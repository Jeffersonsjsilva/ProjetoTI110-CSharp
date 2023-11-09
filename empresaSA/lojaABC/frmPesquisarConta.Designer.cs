
namespace lojaABC
{
    partial class frmPesquisarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarConta));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbbFuncionarios = new System.Windows.Forms.ComboBox();
            this.lbbContas = new System.Windows.Forms.ListBox();
            this.lblSelecionaFuncionario = new System.Windows.Forms.Label();
            this.lblGorjetas = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblCodFunc = new System.Windows.Forms.Label();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(12, 241);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 51);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(123, 241);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 51);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(229, 241);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 51);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cbbFuncionarios
            // 
            this.cbbFuncionarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFuncionarios.FormattingEnabled = true;
            this.cbbFuncionarios.Location = new System.Drawing.Point(26, 34);
            this.cbbFuncionarios.Name = "cbbFuncionarios";
            this.cbbFuncionarios.Size = new System.Drawing.Size(184, 21);
            this.cbbFuncionarios.TabIndex = 4;
            this.cbbFuncionarios.SelectedIndexChanged += new System.EventHandler(this.cbbFuncionarios_SelectedIndexChanged);
            // 
            // lbbContas
            // 
            this.lbbContas.Enabled = false;
            this.lbbContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbContas.FormattingEnabled = true;
            this.lbbContas.ItemHeight = 16;
            this.lbbContas.Location = new System.Drawing.Point(349, 34);
            this.lbbContas.Name = "lbbContas";
            this.lbbContas.Size = new System.Drawing.Size(289, 212);
            this.lbbContas.TabIndex = 5;
            // 
            // lblSelecionaFuncionario
            // 
            this.lblSelecionaFuncionario.AutoSize = true;
            this.lblSelecionaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionaFuncionario.Location = new System.Drawing.Point(23, 9);
            this.lblSelecionaFuncionario.Name = "lblSelecionaFuncionario";
            this.lblSelecionaFuncionario.Size = new System.Drawing.Size(187, 20);
            this.lblSelecionaFuncionario.TabIndex = 6;
            this.lblSelecionaFuncionario.Text = "Selecione um funcionário";
            // 
            // lblGorjetas
            // 
            this.lblGorjetas.AutoSize = true;
            this.lblGorjetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGorjetas.Location = new System.Drawing.Point(413, 9);
            this.lblGorjetas.Name = "lblGorjetas";
            this.lblGorjetas.Size = new System.Drawing.Size(70, 20);
            this.lblGorjetas.TabIndex = 7;
            this.lblGorjetas.Text = "Gorjetas";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.Location = new System.Drawing.Point(23, 129);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(83, 20);
            this.lblDataInicio.TabIndex = 8;
            this.lblDataInicio.Text = "Data início";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInicio.Location = new System.Drawing.Point(26, 152);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(114, 20);
            this.dtpDataInicio.TabIndex = 9;
            // 
            // lblCodFunc
            // 
            this.lblCodFunc.AutoSize = true;
            this.lblCodFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFunc.Location = new System.Drawing.Point(23, 69);
            this.lblCodFunc.Name = "lblCodFunc";
            this.lblCodFunc.Size = new System.Drawing.Size(124, 20);
            this.lblCodFunc.TabIndex = 10;
            this.lblCodFunc.Text = "Cod. funcionário";
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Enabled = false;
            this.txtCodFunc.Location = new System.Drawing.Point(27, 93);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(72, 20);
            this.txtCodFunc.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(504, 252);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(110, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(439, 252);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFinal.Location = new System.Drawing.Point(189, 152);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(114, 20);
            this.dtpDataFinal.TabIndex = 15;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.Location = new System.Drawing.Point(186, 129);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(77, 20);
            this.lblDataFinal.TabIndex = 14;
            this.lblDataFinal.Text = "Data final";
            // 
            // frmPesquisarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 328);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCodFunc);
            this.Controls.Add(this.lblCodFunc);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.lblGorjetas);
            this.Controls.Add(this.lblSelecionaFuncionario);
            this.Controls.Add(this.lbbContas);
            this.Controls.Add(this.cbbFuncionarios);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmPesquisarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar conta";
            this.Load += new System.EventHandler(this.frmPesquisarConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbbFuncionarios;
        private System.Windows.Forms.ListBox lbbContas;
        private System.Windows.Forms.Label lblSelecionaFuncionario;
        private System.Windows.Forms.Label lblGorjetas;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label lblCodFunc;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label lblDataFinal;
    }
}