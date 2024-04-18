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
// Definición del espacio de nombres Datos
namespace Datos
{
    // Declaración de la interfaz IDatos<T>
    public interface IDatos<T>
    {
        // Método para listar elementos de tipo T
        List<T> Listar();

        // Método para insertar un elemento de tipo T
        bool Insertar(T item);

        // Método para actualizar un elemento de tipo T
        bool Actualizar(T item);

        // Método para eliminar un elemento de tipo T
        bool Eliminar(T item);
    }
}
