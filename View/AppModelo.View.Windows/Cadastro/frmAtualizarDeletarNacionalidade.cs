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
    public partial class frmAtualizarDeletarNacionalidade : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();

        public frmAtualizarDeletarNacionalidade()
        {
            InitializeComponent();
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int idDesejado = int.Parse(txtIdDesejado.Text);
            var atualizarNacionalidade = new NacionalidadeRepository();
            var atualizou = atualizarNacionalidade.Atualizar(idDesejado , txtNovaDescricao.Text);

            if (atualizou)
            {
                MessageBox.Show("Dado atualizado com sucesso");
                var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
                gvNacionalidades.DataSource = listaDeNacionalidades;
            }
            else
            {
                MessageBox.Show("Ocorreu Algum erro");
                return;
            }
            
        }
    }
}
