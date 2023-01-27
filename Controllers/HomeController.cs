using Proyecto_Arnold.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Arnold.Controllers
{
    public class HomeController : Controller
    {
        private ListarProducto _listarProducto;

        public HomeController()
        {
            _listarProducto = new ListarProducto();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page";
            var model = _listarProducto.ObtenerProductos();
            return View(model);

        }

    }
}
