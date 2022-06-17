using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Login
    {
        public int Id { get; set; }
        public int Senha { get; set; }
        public string Usuario { get; set; }
        
        public Login()
        {
        }

        public Login(int id, int senha, string usuario)
        {
            Id = id;
            Senha = senha;
            Usuario = usuario;
        }
        
    }
}
