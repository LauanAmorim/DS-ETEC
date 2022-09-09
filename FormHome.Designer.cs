namespace veiculo_aplicacao
{
    partial class FormHome
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrarCarro = new System.Windows.Forms.Button();
            this.btnCadastrarCaminhao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(695, 406);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 32);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrarCarro
            // 
            this.btnCadastrarCarro.Location = new System.Drawing.Point(87, 12);
            this.btnCadastrarCarro.Name = "btnCadastrarCarro";
            this.btnCadastrarCarro.Size = new System.Drawing.Size(293, 264);
            this.btnCadastrarCarro.TabIndex = 1;
            this.btnCadastrarCarro.Text = "Cadastrar carro";
            this.btnCadastrarCarro.UseVisualStyleBackColor = true;
            this.btnCadastrarCarro.Click += new System.EventHandler(this.btnCadastrarCarro_Click);
            // 
            // btnCadastrarCaminhao
            // 
            this.btnCadastrarCaminhao.Location = new System.Drawing.Point(392, 12);
            this.btnCadastrarCaminhao.Name = "btnCadastrarCaminhao";
            this.btnCadastrarCaminhao.Size = new System.Drawing.Size(308, 264);
            this.btnCadastrarCaminhao.TabIndex = 2;
            this.btnCadastrarCaminhao.Text = "Cadastrar caminhão";
            this.btnCadastrarCaminhao.UseVisualStyleBackColor = true;
            this.btnCadastrarCaminhao.Click += new System.EventHandler(this.btnCadastrarCaminhao_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarCaminhao);
            this.Controls.Add(this.btnCadastrarCarro);
            this.Controls.Add(this.btnSair);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrarCarro;
        private System.Windows.Forms.Button btnCadastrarCaminhao;
    }
}

