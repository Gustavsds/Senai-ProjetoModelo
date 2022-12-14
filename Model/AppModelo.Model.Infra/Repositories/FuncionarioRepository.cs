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
    public class FuncionarioRepository
    {
        public bool Inserir(string nomeCompleto, DateTime dataNascimento, bool sexo, string email, string telefone, string telefoneContato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidade, int naturalidade)
        {
            var dataConvertida = dataNascimento.ToString("yyyy-MM-dd");

            var sql = $"INSERT INTO funcionario (nome_completo, data_nascimento, sexo, email, telefone, telefone_contato, cep, logradouro, numero_endereco, complemento, bairro, municipio, uf, nacionalidade, naturalidade) VALUES ('{nomeCompleto}', '{dataConvertida}', {sexo}, '{email}', '{telefone}', '{telefoneContato}', '{cep}', '{logradouro}', {numero}, '{complemento}', '{bairro}', '{municipio}', '{uf}', {nacionalidade}, {naturalidade})";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        public bool Deletar(int id)
        {
            var sql = $"DELETE FROM funcionario WHERE id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;

        }
    }
}
