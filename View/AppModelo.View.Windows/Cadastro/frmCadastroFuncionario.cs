﻿using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastro
{
    public partial class frmCadastroFuncionario : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();

        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);

            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";

            cmbNaturalidade.DataSource = _naturalidadeController.ObterTodasNaturalidade();
            cmbNaturalidade.DisplayMember = "Descricao";
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            var cepController = new ViaCepController();
            var endereco = cepController.Obter(txtCep.Text);
            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;

        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            // primeira regra para verificar se o nome é < que 6 letras.
            if (txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo");
                return;
            }

            // verifica se digitou algum número.
            foreach (var letra in txtNome.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Um nome não pode conter números");
                    return;
                }
            }

            errorProvider.Clear();

        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);

            if (cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF inválido!");
                return;
            }

            errorProvider.Clear();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = txtEmail.Text;
            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider.SetError(txtEmail, "E-mail inválido!");
                return;
            }

            errorProvider.Clear();
        }

        private void txtDataNascimento_Validated(object sender, EventArgs e)
        {

            try
            {
                var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                var dataHoje = DateTime.Now;
                errorProvider.SetError(txtDataNascimento, "Você não pode informar uma data de hoje");

            }

            catch (Exception)
            {
                errorProvider.SetError(txtDataNascimento, "Data Invalida");
            }


        }

    }

}
