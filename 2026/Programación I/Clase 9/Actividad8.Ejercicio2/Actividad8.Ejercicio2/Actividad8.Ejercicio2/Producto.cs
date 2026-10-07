using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad8.Ejercicio2
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto()
        {
            
        }

        /*public Producto(int codigo, string nombre, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }

        public Producto(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }*/
    }
}
