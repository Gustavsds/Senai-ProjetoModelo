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

        private void nacionalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new frmAtualizarDeletarNacionalidade();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.MdiParent = this;
            form.Show();
        }

        private void nacionalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.MdiParent = this;
            form.Show();
        }

        private void naturalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.MdiParent = this;
            form.Show();
        }

        private void naturalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new frmAtualizarDeletarNaturalidade();
            form.MdiParent = this;
            form.Show();
        }
    }
}
 