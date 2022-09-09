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
    }
}
