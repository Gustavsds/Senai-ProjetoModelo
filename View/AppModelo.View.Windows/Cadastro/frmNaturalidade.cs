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
    public partial class frmNaturalidade : Form
    {
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidade()
        {
            InitializeComponent();
            txtId.Enabled = false;
            var listaDeNaturalidade = _naturalidadeController.ObterTodasNaturalidade();
            gvNaturalidade.DataSource = listaDeNaturalidade;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var temNumero = Helpers.Componentes.ProibirNumeroNoTexto(txtDescricao.Text);
            if (temNumero)
            {
                errorProvider1.SetError(txtDescricao, "Naturalidades geralmente não tem numero");
                txtDescricao.Focus();
                return;
            }
            var controller = new NaturalidadeController();
            var descricaoMaiuscula = txtDescricao.Text.ToUpper();

            var resposta = controller.Cadastrar(descricaoMaiuscula, chkStatus.Checked);

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtDescricao.Text.All(char.IsNumber))
            {
                errorProvider1.SetError(txtDescricao, "Apenas letras são permitidas");
                btnCadastrar.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtDescricao, "");
                btnCadastrar.Enabled = true;
            }
        }
    }
    
}      
    
   

