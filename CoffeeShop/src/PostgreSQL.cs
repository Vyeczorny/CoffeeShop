using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

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

        public static object executeScalar(string str)
        {
            NpgsqlCommand command = new NpgsqlCommand(str, connection);
            return command.ExecuteScalar();
        }

        public static void close()
        {
            connection.Close();
        }

        public static object executeScalarWithByteArray(string str, string paramName, byte[] array)
        {
            NpgsqlCommand command = new NpgsqlCommand(str, connection);
            NpgsqlParameter parameter = new NpgsqlParameter(paramName, NpgsqlDbType.Bytea);
            parameter.Value = array;
            command.Parameters.Add(parameter);
            return command.ExecuteScalar();
        }

        private static NpgsqlConnection connection;
    }
}
