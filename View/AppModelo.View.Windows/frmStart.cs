using AppModelo.View.Windows.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.Show();
        }

        private void btnNacionalidade_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.Show();
        }

        private void btnNaturalidade_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.Show();
        }
    }
}
