using mvcEjemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEjemplo1.Controllers
{
    public class ArticulosController : Controller
    {
        bd_cunorEntities bd = new bd_cunorEntities();

        // GET: Articulos
        public ActionResult Index()
        {
            var lstArticulos = (from a in bd.articulo
                                select a).ToList();
            ViewBag.lstArticulos = lstArticulos;
            return View();
        }

        public ActionResult Create() {

            return View();
        }

        [HttpPost]
        public ActionResult Create(articulo articulo) {
            try
            {
                if (ModelState.IsValid) {
                    bd.articulo.Add(articulo);
                    bd.SaveChanges();
                    return RedirectToAction("Index");
                }
                
            }
            catch (Exception ex) {

            }
            
            return View(articulo);
        }

        public ActionResult Edit(int id)
        {
            articulo articulo = bd.articulo.Find(id);

            return View(articulo);
        }

        [HttpPost]
        public ActionResult Edit(articulo articulo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bd.Entry(articulo).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {

            }

            return View(articulo);
        }
    }
}