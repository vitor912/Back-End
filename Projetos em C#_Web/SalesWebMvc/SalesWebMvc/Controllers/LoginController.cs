using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginService _loginService;
        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Login login)
        {
            login.Id = 1;
            _loginService.Insert(login);
            return RedirectToAction(nameof(Login));            
        }

        [HttpGet]
        public IActionResult Buscar(Login login)
        {
            var user = _loginService.Obter(login.Usuario, login.Senha);
            if (user != null)
            {
                return RedirectToAction("/Home/Index");
            }
            else
                return BadRequest();
        }
    }
}
