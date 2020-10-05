using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEjemplo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cunor() {
            ViewBag.valor = "Hola Mundo, esto viene del controlador";
            ViewBag.numero = 5;
            ViewBag.str = new string[] { "Valor 1", "valor 2", "valor 3" };
            return View();
        }

        [HttpGet]
        public ActionResult Cunor2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cunor2(int num, int num2, int num3)
        {
            ViewBag.num = num;
            return View();
        }
    }
}