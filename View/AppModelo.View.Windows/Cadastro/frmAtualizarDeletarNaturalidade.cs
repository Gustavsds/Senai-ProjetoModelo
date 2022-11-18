using AppModelo.Controller.Cadastros;
using AppModelo.Model.Infra.Repositories;
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int idDesejado = int.Parse(txtIdDesejado.Text);
            var atualizarNaturalidade = new NaturalidadeRepository();
            var atualizou = atualizarNaturalidade.Atualizar(idDesejado, txtNovaDescricao.Text);
            if (atualizou)
            {
                MessageBox.Show("Atualizado com sucesso");
                var listaDeNaturalidade = _naturalidadeController.ObterTodasNaturalidade();
                gvNaturalidade.DataSource = listaDeNaturalidade;
            }
            else
            {
                MessageBox.Show("Ocorreu Algum erro");
                return;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int idDesejado = int.Parse(txtIdDesejado.Text);
            var deletarNaturalidade = new NaturalidadeRepository();
            var deletou = deletarNaturalidade.Deletar(idDesejado);
            if (deletou)
            {
                MessageBox.Show("Atualizado com sucesso");
                var listaDeNaturalidade = _naturalidadeController.ObterTodasNaturalidade();
                gvNaturalidade.DataSource = listaDeNaturalidade;
            }
            else
            {
                MessageBox.Show("Ocorreu algum erro");
                return ;
            }
        }
    }
}
