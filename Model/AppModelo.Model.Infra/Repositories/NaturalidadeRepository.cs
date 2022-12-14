using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    public class NaturalidadeRepository
    {
        public bool Inserir(string descricao, bool status)
        {
            var agora = DateTime.Now.ToString("u");

            var sql = $"INSERT INTO naturalidade (descricao,  dataCriacao, dataAlteracao, ativo)  VALUES ('{descricao}', '{agora}', '{agora}', {status})";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());

            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public IEnumerable<NaturalidadeEntity> ObterTodos()
        {
            var sql = "SELECT id, descricao FROM naturalidade";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        public NaturalidadeEntity ObterPorDescricao(string descricao)
        {
            var sql = $"SELECT id, descricao FROM naturalidade WHERE descricao = '{descricao}' ";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<NaturalidadeEntity>(sql);

            return resultado;

        }
        public IEnumerable<NaturalidadeEntity> ObterTodosAtivos()
        {
            var sql = "SELECT id, descricao FROM naturalidade ORDER BY descricao ASC" +
            "WHERE ativo = true";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        public bool Atualizar(int id, string descricao)
        {
            var sql = $"UPDATE naturalidade SET descricao = '{descricao}' WHERE id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public bool Deletar(int id)
        {
            var sql = $"DELETE FROM naturalidade WHERE id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;

        }
    }
}
