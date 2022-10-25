using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Login
{
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            this.Hide();
        }

        private void btnRecuperarAceso_Click(object sender, EventArgs e)
        {
            var form = new frmLogin();
            form.Show();
            this.Hide();    
        }
    }
}
