using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace MvcPelicula.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string nombre, string apellido, int Id = 1)
        {
            ViewData["mensaje"] = "Hola " + nombre + " " + apellido;
            ViewData["id"] =(int) Id;

            return View();
        }
    }
}
