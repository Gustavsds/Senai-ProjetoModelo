using AppModelo.Model.Infra.Repositories;
using AppModelo.Model.Infra.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Seguranca
{
    public class UsuarioController
    {
        public bool EfetuarLogin(string email, string senha)
        {
            var repositorio = new UsuarioRepository();
            var usuarioEncontrado = repositorio.Obter(email, senha);
            if(usuarioEncontrado is not null)
            {
                return true;
            }
            else
            {
                return false;   
            }
            
        }
        public string RecuperarSenha(string email)
        {
            var repository = new UsuarioRepository();
            var usuario = repository.ObterEmail(email);
            if(usuario is not null)
            {
                return "Usuário não foi encontrado";
            }
            return "";
            var novaSenha = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            var atualizouSenha = repository.AtualizarSenha(email, novaSenha);
            if(atualizouSenha is false)
            {
                return "Houve em erro ao alterar sua senha no banco de dados ";
            }
            var emailService = new EmailService();
            var mensagemHtml = @"<p><b>Criamos uma nova senha para você</b></p><p>Sua nova senha é: <b>" + novaSenha + "</b></p>";
            var emailEnviado = emailService.EnviarEmail(usuario.Nome, usuario.Email, "Recuperação de senha", mensagemHtml);
            return "";
        }
    }
}
