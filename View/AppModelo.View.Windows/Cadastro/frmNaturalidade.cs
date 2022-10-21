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
            var salvou = _naturalidadeController.Cadastrar(txtDescricao.Text);

            if (salvou)
            {
                MessageBox.Show("Naturalidade incluída com sucesso");
                txtDescricao.Text = string.Empty;
            }

            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados");

            } 
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtDescricao.Text.All(char.IsNumber))
            {
                errorProvider1.SetError(txtDescricao, "Apenas letras são permitidas");
            }
            else
            {
                errorProvider1.SetError(txtDescricao, "");
            }
        }
    }
    
}      
    
   

