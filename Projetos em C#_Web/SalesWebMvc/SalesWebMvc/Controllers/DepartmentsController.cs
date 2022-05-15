using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;


namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Eletronicos" });
            list.Add(new Departamento { Id = 2, Nome = "Fashion" });
            list.Add(new Departamento { Id = 3, Nome = "Acessórios" });

            
            
            return View(list);
        }
    }
}
