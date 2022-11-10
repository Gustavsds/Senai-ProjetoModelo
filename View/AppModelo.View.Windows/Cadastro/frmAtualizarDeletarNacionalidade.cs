using AppModelo.Controller.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastro
{
    public partial class frmAtualizarDeletarNacionalidade : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();

        public frmAtualizarDeletarNacionalidade()
        {
            InitializeComponent();
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }
    }
}
