using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion_Con_MySQL
{  
    class ConexionDB
    {
        public static MySqlConnection Conexion()
        {
            string server = "Server=localhost;";
            string database = "Database=example;";
            string user = "User ID=root;";
            string password = "Password=12345;";
            string pooling = "Pooling=false";


            string connection_string = server + database + user + password + pooling;

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(connection_string);

                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
