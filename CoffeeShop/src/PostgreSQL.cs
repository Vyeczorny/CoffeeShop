using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CoffeeShop
{
    public class PostgreSQL
    {
        public static void connect(string database, string hostname, string login, string password)
        {
            connection = new NpgsqlConnection(
                  "Server=" + hostname 
                + ";Port=5432;User Id=" + login 
                + ";Password=" + password 
                + ";Database=" + database
                + ";");
            connection.Open();
        }

        public static NpgsqlDataReader executeCommand(string str)
        {
            NpgsqlCommand command = new NpgsqlCommand(str, connection);
            return command.ExecuteReader();
        }

        public static void close()
        {
            connection.Close();
        }


        private static NpgsqlConnection connection;
    }
}
