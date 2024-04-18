using AccesoDatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
// NOMBRE APELLIDOS: Carrera Molina Danny Sebastián
// PARALELO: 215
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 21/04/2024
// PRÁCTICA No. 4 #
namespace APPISOA
{
    /// <summary>
    /// Descripción breve de ServicioaCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioaCliente : System.Web.Services.WebService
    {
        [WebMethod]
        public List<Clientes> Clientes()
        {
            Logica datos = new Logica();
            List<Clientes> lista = datos.ListarClientes();
            return lista;

        }

    }
}
