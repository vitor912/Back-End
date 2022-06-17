using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelaDeLogin.Models;


namespace TelaDeLogin.Controllers
{       
    public class LoginController : Controller
    {
              
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void ChecarLogin ()
        {
            var usuario = new Usuarios();
            usuario.Email = Request["Email"];
            usuario.Senha = Request["PassWord"];

            if (usuario.Login())
            {
                Session["Autorizado"] = "Ok";
                Response.Redirect("/Home/Index");
            }
            else
                Response.Redirect("/Login/Index");

        }
    }
}
