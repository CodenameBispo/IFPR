using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExemploMVCWebForms.dao
{
    public class Conexao
    {
        private SqlConnection connection;

        public Conexao()
        {
            string stringConnection = "Data Source=(localdb)\\MSSQL";
            connection = new SqlConnection(stringConnection);
            connection.Open();
        }
        public SqlConnection Connection
        {
            get => connection;
            set => connection = value;
        }
        public void Dispose()
        {
            connection.Close();
        }

    }
}