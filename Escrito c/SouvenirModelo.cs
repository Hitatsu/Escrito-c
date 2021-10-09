using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaDeDatos;

namespace CapaDeDatos
{
    public class SouvenirModelo : Modelo
    {
        public int Id;
        public string Nombre;
        public string Descripcion;
        public string Stock;
        public string Precio;
        public string FechaDeAlta;


        private void EjecutarQuery()
        {
            this.comando.ExecuteNonQuery();
        }

        private void GuardarSouvenir()
        {
            this.comando.CommandText = "INSERT INTO souvenir (id,nombre,descripcion,stock,precio,fechadealta) VALUES(@id,@nombre,@descripcion,@stock,@precio,@fechadealta);";

            this.comando.Parameters.AddWithValue("@id", this.Id);
            this.comando.Parameters.AddWithValue("@nombre", this.Nombre);
            this.comando.Parameters.AddWithValue("@descripcion", this.Descripcion);
            this.comando.Parameters.AddWithValue("@stock", this.Stock);
            this.comando.Parameters.AddWithValue("@precio", this.Precio);
            this.comando.Parameters.AddWithValue("@fechadealta", this.FechaDeAlta);
            this.comando.Prepare();

            EjecutarQuery();
        }

        private void BorrarSouvenir()
        {
            this.comando.CommandText = "DELETE souvenir WHERE nombre=@nombre;";
            this.comando.Parameters.AddWithValue("nombre", this.Nombre);
            this.comando.Prepare();

            EjecutarQuery();
        }

        public void ActualizarSouvenir()
        {
            this.comando.CommandText = "UPDATE souvenir SET stock=@stock AND precio=@precio WHERE id=@id;";
            this.comando.Parameters.AddWithValue("stock", this.Stock);
            this.comando.Parameters.AddWithValue("precio", this.Precio);
            this.comando.Prepare();

            EjecutarQuery();
        }

        private void Obtener()
        {
            this.comando.CommandText = "SELECT id,nombre,descripcion,stock,precio FROM souvenir;";
            List<SouvenirModelo> souvenirs = new List<SouvenirModelo>();
            lector = this.comando.ExecuteReader();
            while (lector.Read())
            {
                SouvenirModelo s = new SouvenirModelo();
                s.Id = int.Parse(lector[0].ToString());
                s.Nombre = lector[1].ToString();
                s.Descripcion = lector[2].ToString();
                s.Stock = lector[3].ToString();
                s.Precio = lector[4].ToString();
                souvenirs.Add(s);
            }

            lector.Close();


        }


    }


}
