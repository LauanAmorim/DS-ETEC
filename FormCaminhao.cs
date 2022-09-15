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
    public partial class FormCaminhao : Form
    {
        Caminhao caminhao;
        public FormCaminhao()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormHome frmHome = new FormHome();
            this.Hide();
            frmHome.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            caminhao = new Caminhao(txtMarca.Text);
            txtMarca.Clear();
            txtModelo.Clear();
            txtPreco.Clear();
            txtCombustivel.Clear();
            txtPlaca.Clear();
            txtCor.Clear();
            txtChassi.Clear();
            txtTipoCabine.Clear();
            txtTipoCarga.Clear();
            txtCapacidadeCarga.Clear();
            txtEixo.Clear();
        }

        private void FormCarro_Load(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.RegistrarVeiculo());
        }
    }
    }
}
