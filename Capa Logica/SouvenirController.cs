using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace Capa_Logica
{
    public static class SouvenirController
    {

        public static void AltaSouvenir(int id,string nombre,string descripcion,string stock,string precio,string fechadealta)
        {
            SouvenirModelo s = new SouvenirModelo();
            s.Id = id;
            s.Nombre = nombre;
            s.Descripcion = descripcion;
            s.Stock = stock;
            s.Precio = precio;
            s.FechaDeAlta = fechadealta;
        }

        public static void BajaSouvenir(int id)
        {
            SouvenirModelo s = new SouvenirModelo();
            s.Id = id;
            s.BorrarSouvenir();

        }
    }
}
