
namespace MercadoSA
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ckbLivro = new System.Windows.Forms.CheckBox();
            this.cbbProdutos = new System.Windows.Forms.ComboBox();
            this.dtpCalendario = new System.Windows.Forms.DateTimePicker();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(152, 241);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(212, 238);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(212, 288);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // ckbLivro
            // 
            this.ckbLivro.AutoSize = true;
            this.ckbLivro.Location = new System.Drawing.Point(319, 240);
            this.ckbLivro.Name = "ckbLivro";
            this.ckbLivro.Size = new System.Drawing.Size(49, 17);
            this.ckbLivro.TabIndex = 3;
            this.ckbLivro.Text = "Livro";
            this.ckbLivro.UseVisualStyleBackColor = true;
            // 
            // cbbProdutos
            // 
            this.cbbProdutos.FormattingEnabled = true;
            this.cbbProdutos.Location = new System.Drawing.Point(424, 236);
            this.cbbProdutos.Name = "cbbProdutos";
            this.cbbProdutos.Size = new System.Drawing.Size(121, 21);
            this.cbbProdutos.TabIndex = 4;
            // 
            // dtpCalendario
            // 
            this.dtpCalendario.Location = new System.Drawing.Point(560, 12);
            this.dtpCalendario.Name = "dtpCalendario";
            this.dtpCalendario.Size = new System.Drawing.Size(228, 20);
            this.dtpCalendario.TabIndex = 5;
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(668, 50);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(120, 95);
            this.lstProdutos.TabIndex = 6;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(293, 291);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 7;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.dtpCalendario);
            this.Controls.Add(this.cbbProdutos);
            this.Controls.Add(this.ckbLivro);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox ckbLivro;
        private System.Windows.Forms.ComboBox cbbProdutos;
        private System.Windows.Forms.DateTimePicker dtpCalendario;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.RadioButton rdbFeminino;
    }
}

