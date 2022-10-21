namespace AppModelo.Model.Infra.Databases
{
    public static class MySql
    {
        public static string ConnectionString()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline04;uid=wwonline04;password=aluno22senai;";
            return conn;
        }
    }
}

