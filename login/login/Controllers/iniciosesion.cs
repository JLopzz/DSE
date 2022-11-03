using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using login.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace login.Controllers
{
    public class iniciosesion : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public List<userInfo> listaUsuarios = new List<userInfo>();
        //private string Msg = "";
        //private bool Flag = false;
        public IActionResult Index()
        {
            ViewData["err"] = false;
            //ConnDB c = new ConnDB();
            //listaUsuarios = await c.ConsultaUsuarios("select * from usuarios", listaUsuarios);
            return View();
        }

        public async Task<IActionResult> LogIn(string user , string psw )
        {
            ConnDB c = new ConnDB();
            String[] res; //= new String[2];
            res = await c.LogInDB(user, psw);
            ViewData["err"] = false;
            if ( res.GetValue(0).ToString() != "ok")
            {
                ViewData["errMsg"] = res.GetValue(0).ToString();
                ViewData["err"] = true;
                return View("Index");
            }
            else
                return View("main");
        }
        //[AuthorizeUsers]
        public IActionResult main()
        {
            return View();
        }
    }

    public class userInfo
    {
        public int id;
        public string nombre;
        public string apellido;
        public string correo;
        public int edad;
        public string dui;
        public string genero;
        public int id_rol;
        public string password;
    }
}

