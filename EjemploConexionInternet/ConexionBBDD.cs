using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EjemploConexionInternet
{
    class ConexionBBDD
    {
        public MySqlConnection conecta()
        {
            /*
             * se necesitan 5 parámetros :
             * 1ª Server:IP o nombre del servidor
             * 2ª Database: Nombre de la BBDD
             * 3ª UID : Uder ID (not null)
             * 4ª Password : contraseña
             * 5ª Port : puerto, por defectp es el 3306
             */

            MySqlConnection conexion = new MySqlConnection(
                "Server=127.0.0.1 ;" +
                "Database= videoclub ;" +
                "Uid= root1234;" +
                "Pwd=;" +
                "Port=3306");
            conexion.Open();

            return conexion;
        }
    }
}
