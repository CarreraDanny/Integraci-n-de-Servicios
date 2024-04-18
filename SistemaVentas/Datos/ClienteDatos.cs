using AccesoDatos;
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
// Espacio de nombres Datos
namespace Datos
{
    // Clase ClienteDatos que implementa la interfaz IDatos<Clientes>
    public class ClienteDatos : IDatos<Clientes>
    {
        // Declaración de un contexto de base de datos
        ServiciosEntities contexto;

        // Constructor de la clase ClienteDatos
        public ClienteDatos()
        {
            // Inicialización del contexto de base de datos
            contexto = new ServiciosEntities();
        }

        // Método para actualizar un cliente en la base de datos
        public bool Actualizar(Clientes item)
        {
            throw new NotImplementedException(); // Se lanza una excepción ya que aún no se ha implementado este método
        }

        // Método para eliminar un cliente de la base de datos
        public bool Eliminar(Clientes item)
        {
            throw new NotImplementedException(); // Se lanza una excepción ya que aún no se ha implementado este método
        }

        // Método para insertar un nuevo cliente en la base de datos
        public bool Insertar(Clientes item)
        {
            try
            {
                contexto.Clientes.Add(item);
                contexto.SaveChanges();
                return true;
            }catch (Exception) {
                return false;
            }
             // Se lanza una excepción ya que aún no se ha implementado este método
        }

        // Método para listar todos los clientes de la base de datos
        public List<Clientes> Listar()
        {
            return contexto.Clientes.ToList();
            
        }
       
    }
}

