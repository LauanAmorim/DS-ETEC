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
    public partial class FormCarro : Form
    {
        Carro carro;

        public FormCarro()
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
            carro = new Carro(txtMarca.Text, txtModelo.Text, (Convert.ToDouble(txtPreco.Text)), txtCombustivel.Text, txtPlaca.Text, txtCor.Text, (Convert.ToInt32(txtChassi.Text)), (Convert.ToInt32(txtPortas.Text)), (Convert.ToInt32(txtCapacidadeBagagem.Text)), txtCategoria.Text);
            txtMarca.Clear();
            txtModelo.Clear();
            txtPreco.Clear();
            txtCombustivel.Clear();
            txtPlaca.Clear();
            txtCor.Clear();
            txtChassi.Clear();
            txtPortas.Clear();
            txtCapacidadeBagagem.Clear();
            txtCategoria.Clear();
        }

        private void FormCarro_Load(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.RegistrarVeiculo());
        }
    }
}
