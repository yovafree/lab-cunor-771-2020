using mvcEjemplo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEjemplo2.Controllers
{
    public class VentasController : Controller
    {
        private ctxVentas db = new ctxVentas();
        // GET: Ventas
        public ActionResult Index()
        {

            return View(db.venta.ToList());
        }

        public ActionResult Create() {
            var lstClientes = db.cliente.ToList();
            var lstProductos = db.producto.ToList();

            ViewBag.lstClientes = new SelectList(lstClientes, "cod_cliente", "nombre");
            ViewBag.lstProductos = lstProductos;

            return View();
        }

        [HttpPost]
        public ActionResult Create(venta v) {
            if (ModelState.IsValid)
            {
                db.venta.Add(v);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(v);
        }
    }
}