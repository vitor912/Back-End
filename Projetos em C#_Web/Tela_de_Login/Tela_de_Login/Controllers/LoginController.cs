using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tela_de_Login.Controllers
{
    public class LoginController : Controller
    {
        // Chamando: Index da pasta Login (Views)
        public IActionResult Index()
        {
            return View();
        }
    }
}
