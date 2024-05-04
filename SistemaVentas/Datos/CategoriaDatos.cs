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
    // Clase CategoriaDatos que implementa la interfaz IDatos<Categoria>
    public class CategoriaDatos : IDatos<Categoria>
    {
        // Método para actualizar una categoría en la fuente de datos
        public bool Actualizar(Categoria item)
        {
            throw new NotImplementedException(); // Se lanza una excepción ya que aún no se ha implementado este método
        }

        // Método para eliminar una categoría de la fuente de datos
        public bool Eliminar(Categoria item)
        {
            throw new NotImplementedException(); // Se lanza una excepción ya que aún no se ha implementado este método
        }

        // Método para insertar una nueva categoría en la fuente de datos
        public bool Insertar(Categoria item)
        {
            throw new NotImplementedException(); // Se lanza una excepción ya que aún no se ha implementado este método
        }

        // Método para listar todas las categorías de la fuente de datos
        public List<Categoria> Listar()
        {
            throw new NotImplementedException(); // Se lanza una excepción ya que aún no se ha implementado este método
        }
    }
}

