using System;
using System.Data.SqlClient;

namespace BancoDelTiempo
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection
                ("Data Source=.\\SQLSERVER;Initial Catalog=BancoDelTiempo;Integrated Security=True");
        }

       
    }
}
