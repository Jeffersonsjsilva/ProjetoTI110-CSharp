
namespace lojaABC
{
    partial class frmWebCam
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
            this.pctDispositivos = new System.Windows.Forms.PictureBox();
            this.lblDispostivo = new System.Windows.Forms.Label();
            this.cbbDispositivos = new System.Windows.Forms.ComboBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.sfdSalvarImagem = new System.Windows.Forms.SaveFileDialog();
            this.ofdAbrirImagem = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctDispositivos)).BeginInit();
            this.SuspendLayout();
            // 
            // pctDispositivos
            // 
            this.pctDispositivos.Location = new System.Drawing.Point(38, 12);
            this.pctDispositivos.Name = "pctDispositivos";
            this.pctDispositivos.Size = new System.Drawing.Size(364, 250);
            this.pctDispositivos.TabIndex = 0;
            this.pctDispositivos.TabStop = false;
            // 
            // lblDispostivo
            // 
            this.lblDispostivo.AutoSize = true;
            this.lblDispostivo.Location = new System.Drawing.Point(35, 294);
            this.lblDispostivo.Name = "lblDispostivo";
            this.lblDispostivo.Size = new System.Drawing.Size(63, 13);
            this.lblDispostivo.TabIndex = 1;
            this.lblDispostivo.Text = "Dispositivos";
            // 
            // cbbDispositivos
            // 
            this.cbbDispositivos.FormattingEnabled = true;
            this.cbbDispositivos.Location = new System.Drawing.Point(38, 328);
            this.cbbDispositivos.Name = "cbbDispositivos";
            this.cbbDispositivos.Size = new System.Drawing.Size(189, 21);
            this.cbbDispositivos.TabIndex = 2;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(449, 12);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(223, 68);
            this.btnCapturar.TabIndex = 3;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(449, 110);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(223, 68);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ofdAbrirImagem
            // 
            this.ofdAbrirImagem.FileName = "openFileDialog1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(449, 205);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(223, 68);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(515, 318);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 31);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.cbbDispositivos);
            this.Controls.Add(this.lblDispostivo);
            this.Controls.Add(this.pctDispositivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmWebCam";
            this.Text = "Captura de imagem";
            this.Load += new System.EventHandler(this.frmWebCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctDispositivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctDispositivos;
        private System.Windows.Forms.Label lblDispostivo;
        private System.Windows.Forms.ComboBox cbbDispositivos;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.SaveFileDialog sfdSalvarImagem;
        private System.Windows.Forms.OpenFileDialog ofdAbrirImagem;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSair;
    }
}