using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_1
{
    class Conexion
    {
        public static MySqlConnection getConexion()
        {
            string servidor = "containers-us-west-78.railway.app";
            string puerto = "7841";
            string usuario = "root";
            string password = "m3tRbsEjo7KU0uN9amMp";
            string bd = "railway";

            string cadenaConexion = 
                "server=" + servidor + 
                "; port=" + puerto + 
                "; user id="+ usuario + 
                "; password="+password+
                "; database="+bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;
        }
    }
}
