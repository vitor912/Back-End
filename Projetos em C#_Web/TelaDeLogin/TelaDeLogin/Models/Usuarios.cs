using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelaDeLogin.Models;

namespace TelaDeLogin.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public bool Login()
        {
            bool result = false;
            var mysql = "SELECT Id, Nome, Senha FROM Usuarios WHERE Email = '" + this.Email + " ' ";

            try
            {

                using (var cn = new MySqlConnection())
                {
                    cn.Open();
                    using (var cmd = new MySqlCommand(mysql, cn))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    if (this.Senha == dr["senha"].ToString())
                                    {
                                        this.Id = Convert.ToInt32(dr["id"]);
                                        this.Nome = dr["nome"].ToString();
                                        result = true;                                          
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch { }
            return result;
        }
    }
}