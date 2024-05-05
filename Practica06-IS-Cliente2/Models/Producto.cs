using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica06_IS_Cliente2.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public bool Iva {  get; set; }

        public Producto() { }

        public Producto(int id, string nombre, decimal precio, bool iva)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Iva = iva;
        }
    }
}