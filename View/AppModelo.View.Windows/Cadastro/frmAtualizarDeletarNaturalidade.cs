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
    public partial class frmAtualizarDeletarNaturalidade : Form
    {
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmAtualizarDeletarNaturalidade()
        {
            InitializeComponent();
            var listaDeNaturalidade = _naturalidadeController.ObterTodasNaturalidade();
            gvNaturalidade.DataSource = listaDeNaturalidade;
        }
    }
}
