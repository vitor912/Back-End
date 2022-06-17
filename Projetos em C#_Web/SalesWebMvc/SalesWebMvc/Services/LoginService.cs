using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class LoginService
    {
        private readonly SalesWebMvcContext _context;

        public LoginService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Login> FindAll()
        {
            return _context.Logins.ToList();
        }

        public void Insert(Login obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Login Obter(string usuario, int senha)
        {
            var user = _context.Logins.Where(x => x.Usuario == usuario && x.Senha == senha).FirstOrDefault();
            return user;
        }
    }
}
