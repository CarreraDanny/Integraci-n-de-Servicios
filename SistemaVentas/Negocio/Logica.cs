using AccesoDatos;
using Datos;
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
namespace Negocio
{
    public class Logica
    {
        // Método para listar todos los clientes
        public List<Clientes> ListarClientes()
        {
            // Instanciamos la clase ClienteDatos para acceder a los datos de los clientes
            ClienteDatos datos = new ClienteDatos();

            // Llamamos al método Listar de la clase ClienteDatos para obtener la lista de clientes
            List<Clientes> lista = datos.Listar();

            // Retornamos la lista de clientes obtenida
            return lista;
        }

        // Método para listar un cliente por su ID
        public Clientes ListarClientesXId(int id)
        {
            // Instanciamos la clase ClienteDatos para acceder a los datos de los clientes
            ClienteDatos datos = new ClienteDatos();

            // Utilizamos LINQ para filtrar la lista de clientes y obtener el cliente con el ID especificado
            // Si no se encuentra ningún cliente con ese ID, se devuelve null
            Clientes cli = datos.Listar().Where(c => c.id == id).SingleOrDefault();

            // Retornamos el cliente obtenido
            return cli;
        }
    }
}

