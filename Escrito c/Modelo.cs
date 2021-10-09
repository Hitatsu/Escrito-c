using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class Modelo
    {

        public string IpDb;
        public string NombreDb;
        public string UsuarioDb;
        public string PasswordDb;
        protected MySqlCommand comando;
        protected MySqlDataReader lector;




        public Modelo()
        {
            this.InicializarConexion();
            MySqlConnection conexion = new MySqlConnection(
                "server=" + this.IpDb + ";" +
                "userid=" + this.NombreDb + ";" +
                "password=" + this.UsuarioDb + ";" +
                "database=" + this.PasswordDb + ";"

                );

            conexion.Open();
        }

        protected void InicializarConexion()
        {
            this.IpDb = "localhost";
            this.NombreDb = "base";
            this.UsuarioDb = "root";
            this.PasswordDb = "1234";
        }
    }

}
