using mvcEjemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEjemplo1.Controllers
{
    public class BlogController : Controller
    {
        bd_cunorEntities bd = new bd_cunorEntities();

        // GET: Blog
        public ActionResult Index()
        {
            var lstArticulos = (from a in bd.articulo
                               where a.estado == true
                               orderby a.fec_publicacion descending
                               select a).ToList();

            ViewBag.lstArticulos = lstArticulos;
            return View();
        }

        public ActionResult Entrada(int id) {
            articulo articulo = bd.articulo.Find(id);

            var lstComentarios = (from c in bd.comentario
                                  where c.cod_articulo == id
                                  select c).ToList();

            if (articulo != null)
            {
                ViewBag.articulo = articulo;
                ViewBag.cod_articulo = id;
                ViewBag.lstComentarios = lstComentarios;
            }
            else {
                return HttpNotFound();
            }
            return View();
        }

        [HttpPost]
        public ActionResult CreateComentario(comentario c) {
            c.fec_creacion = DateTime.Now;
            try
            {
                if (ModelState.IsValid)
                {
                    bd.comentario.Add(c);
                    bd.SaveChanges();
                    return RedirectToAction("Entrada", new { id = c.cod_articulo });
                }

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}