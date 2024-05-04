using AccesoDatos;
using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// NOMBRE APELLIDOS: Carrera Molina Danny Sebastián
// PARALELO: 215
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 21/04/2024
// PRÁCTICA No. 4 #
namespace PRUEBAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logica datos = new Logica();
            List<Clientes> lista = datos.ListarClientes();
            foreach(var item in lista)
            {
                Console.WriteLine(item.nombre+" "+item.cedula);
            }
            Console.ReadKey();
           
        }
    }
}
