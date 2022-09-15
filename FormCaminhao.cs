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
            caminhao = new Caminhao(txtMarca.Text, txtModelo.Text, (Convert.ToDouble(txtPreco.Text)), txtCombustivel.Text, txtPlaca.Text, txtCor.Text, (Convert.ToInt32(txtChassi.Text)), txtTipoCarga.Text, (Convert.ToDouble(txtCapacidadeCarga.Text)), txtTipoCabine.Text, (Convert.ToInt32(txtEixo.Text)));
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

        private void btnExibir_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.RegistrarVeiculo());
        }
    }
}
