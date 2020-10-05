using mvcEjemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEjemplo1.Controllers
{
    public class EjemplosController : Controller
    {
        // GET: Ejemplos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Eje1() {

            return View();
        }

        [HttpPost]
        public ActionResult Eje1(FormCollection formCollection) {
            string _nombre = formCollection["usr"];
            string _contrasenia = formCollection["pwd"];
            string _se_recuerda = formCollection["rme"];

            ViewBag.info = new string[] { _nombre, _contrasenia, _se_recuerda };

            return View();
        }

        public ActionResult Eje2()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Eje2(Usuario usuario)
        {
            string _nombre = usuario.Nombre + " " + usuario.Apellidos;
            string _email = usuario.Email;

            ViewBag.info = new string[] { _nombre, _email};

            return View();
        }
    }
}