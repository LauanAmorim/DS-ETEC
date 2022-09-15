namespace veiculo_aplicacao
{
    partial class FormCaminhao
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblTipoCabine = new System.Windows.Forms.Label();
            this.txtTipoCabine = new System.Windows.Forms.TextBox();
            this.lblTipoCarga = new System.Windows.Forms.Label();
            this.lblCapacidadeCarga = new System.Windows.Forms.Label();
            this.lblChassi = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.txtTipoCarga = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtCapacidadeCarga = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblEixo = new System.Windows.Forms.Label();
            this.txtEixo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(695, 406);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 32);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibir.Location = new System.Drawing.Point(52, 236);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(127, 27);
            this.btnExibir.TabIndex = 54;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click_1);
            // 
            // lblTipoCabine
            // 
            this.lblTipoCabine.AutoSize = true;
            this.lblTipoCabine.Location = new System.Drawing.Point(49, 191);
            this.lblTipoCabine.Name = "lblTipoCabine";
            this.lblTipoCabine.Size = new System.Drawing.Size(78, 13);
            this.lblTipoCabine.TabIndex = 53;
            this.lblTipoCabine.Text = "Tipo de cabine";
            // 
            // txtTipoCabine
            // 
            this.txtTipoCabine.Location = new System.Drawing.Point(52, 207);
            this.txtTipoCabine.Name = "txtTipoCabine";
            this.txtTipoCabine.Size = new System.Drawing.Size(127, 20);
            this.txtTipoCabine.TabIndex = 52;
            // 
            // lblTipoCarga
            // 
            this.lblTipoCarga.AutoSize = true;
            this.lblTipoCarga.Location = new System.Drawing.Point(368, 88);
            this.lblTipoCarga.Name = "lblTipoCarga";
            this.lblTipoCarga.Size = new System.Drawing.Size(74, 13);
            this.lblTipoCarga.TabIndex = 51;
            this.lblTipoCarga.Text = "Tipo de Carga";
            // 
            // lblCapacidadeCarga
            // 
            this.lblCapacidadeCarga.AutoSize = true;
            this.lblCapacidadeCarga.Location = new System.Drawing.Point(368, 137);
            this.lblCapacidadeCarga.Name = "lblCapacidadeCarga";
            this.lblCapacidadeCarga.Size = new System.Drawing.Size(110, 13);
            this.lblCapacidadeCarga.TabIndex = 50;
            this.lblCapacidadeCarga.Text = "Capacidade de Carga";
            // 
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Location = new System.Drawing.Point(49, 137);
            this.lblChassi.Name = "lblChassi";
            this.lblChassi.Size = new System.Drawing.Size(38, 13);
            this.lblChassi.TabIndex = 49;
            this.lblChassi.Text = "Chassi";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(368, 43);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(23, 13);
            this.lblCor.TabIndex = 48;
            this.lblCor.Text = "Cor";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(209, 137);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 47;
            this.lblPlaca.Text = "Placa";
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Location = new System.Drawing.Point(209, 88);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(66, 13);
            this.lblCombustivel.TabIndex = 46;
            this.lblCombustivel.Text = "Combustível";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(49, 88);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 45;
            this.lblPreco.Text = "Preço";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(209, 43);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 44;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(49, 43);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 43;
            this.lblMarca.Text = "Marca";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(371, 236);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(127, 27);
            this.btnExcluir.TabIndex = 42;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnVender
            // 
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.Location = new System.Drawing.Point(371, 203);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(127, 27);
            this.btnVender.TabIndex = 40;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Location = new System.Drawing.Point(212, 236);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(127, 27);
            this.btnRegistrar.TabIndex = 39;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(371, 59);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(127, 20);
            this.txtCor.TabIndex = 38;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(212, 153);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(127, 20);
            this.txtPlaca.TabIndex = 37;
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Location = new System.Drawing.Point(212, 104);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(127, 20);
            this.txtCombustivel.TabIndex = 36;
            // 
            // txtTipoCarga
            // 
            this.txtTipoCarga.Location = new System.Drawing.Point(371, 104);
            this.txtTipoCarga.Name = "txtTipoCarga";
            this.txtTipoCarga.Size = new System.Drawing.Size(127, 20);
            this.txtTipoCarga.TabIndex = 35;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(52, 104);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(127, 20);
            this.txtPreco.TabIndex = 34;
            // 
            // txtChassi
            // 
            this.txtChassi.Location = new System.Drawing.Point(52, 153);
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(127, 20);
            this.txtChassi.TabIndex = 33;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(212, 59);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(127, 20);
            this.txtModelo.TabIndex = 32;
            // 
            // txtCapacidadeCarga
            // 
            this.txtCapacidadeCarga.Location = new System.Drawing.Point(371, 153);
            this.txtCapacidadeCarga.Name = "txtCapacidadeCarga";
            this.txtCapacidadeCarga.Size = new System.Drawing.Size(127, 20);
            this.txtCapacidadeCarga.TabIndex = 31;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(52, 59);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(127, 20);
            this.txtMarca.TabIndex = 30;
            // 
            // lblEixo
            // 
            this.lblEixo.AutoSize = true;
            this.lblEixo.Location = new System.Drawing.Point(209, 187);
            this.lblEixo.Name = "lblEixo";
            this.lblEixo.Size = new System.Drawing.Size(27, 13);
            this.lblEixo.TabIndex = 56;
            this.lblEixo.Text = "Eixo";
            // 
            // txtEixo
            // 
            this.txtEixo.Location = new System.Drawing.Point(212, 203);
            this.txtEixo.Name = "txtEixo";
            this.txtEixo.Size = new System.Drawing.Size(127, 20);
            this.txtEixo.TabIndex = 55;
            // 
            // FormCaminhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEixo);
            this.Controls.Add(this.txtEixo);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lblTipoCabine);
            this.Controls.Add(this.txtTipoCabine);
            this.Controls.Add(this.lblTipoCarga);
            this.Controls.Add(this.lblCapacidadeCarga);
            this.Controls.Add(this.lblChassi);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtCombustivel);
            this.Controls.Add(this.txtTipoCarga);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtChassi);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtCapacidadeCarga);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaminhao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarCaminhao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblTipoCabine;
        private System.Windows.Forms.TextBox txtTipoCabine;
        private System.Windows.Forms.Label lblTipoCarga;
        private System.Windows.Forms.Label lblCapacidadeCarga;
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.TextBox txtTipoCarga;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtCapacidadeCarga;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblEixo;
        private System.Windows.Forms.TextBox txtEixo;
    }
}