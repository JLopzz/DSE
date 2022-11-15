using Model;
using Repository;
using Sys.Inventarios.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sys.Inventarios.Helpers;

namespace Sys.Inventarios.Controllers
{
    [Autenticado]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //SessionHelper.DestroyUserSession();
            ViewBag.Page = "Index";
            IRepository repository = new Model.Repository();
            var objResult = repository.FindEntity<Usuarios>(c => true);
            return View(objResult);
        }
    }
}