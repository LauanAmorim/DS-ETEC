using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veiculo_aplicacao
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {
            FormCarro frmCarro = new FormCarro();
            this.Hide();
            frmCarro.Show();
        }

        private void btnCadastrarCaminhao_Click(object sender, EventArgs e)
        {
            FormCaminhao frmCaminhao = new FormCaminhao();
            this.Hide();
            frmCaminhao.Show();
        }
    }
}
