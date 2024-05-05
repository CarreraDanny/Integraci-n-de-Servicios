using Newtonsoft.Json;
using Practica06_IS_Cliente2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Compilation;
using System.Web.Mvc;

namespace Practica06_IS_Cliente2.Controllers
{
    public class ProductosController : Controller
    {
        private List<Producto> Deserializar()
        {
            string url = "http://localhost:53365/api/Productos";
            WebClient client = new WebClient();
            string getDatos = client.DownloadString(new Uri(url));

            List<Producto> listaProductos = JsonConvert.DeserializeObject<List<Producto>>(getDatos);
            return listaProductos;
        }
        private void Serializar(Producto producto)
        {
            string url = "http://localhost:53365/api/Productos";
            string verb = "POST";
            WebClient webClient = new WebClient();

            string JsonDatos = JsonConvert.SerializeObject(producto);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(JsonDatos);
            webClient.Headers.Add("content-type", "application/json");
            webClient.UploadData(url,verb,bytes);   
        }

        // GET: Productos
        public ActionResult Index()
        {
            return View(Deserializar());
        }

        // GET: Productos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Productos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Productos/Create
        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            try
            {
                Serializar(producto);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Productos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Productos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Productos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Productos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
