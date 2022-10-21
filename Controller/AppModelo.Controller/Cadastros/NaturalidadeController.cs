using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
        public bool Cadastrar(string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }
        public List<NaturalidadeEntity> ObterTodasNaturalidade()
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NaturalidadeEntity>)resposta;
        }
    }
}
