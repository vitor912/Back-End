using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TelaDeLogin.Models
{
    public class TelaDeLoginContext : DbContext
    {
        public TelaDeLoginContext (DbContextOptions<TelaDeLoginContext> options)
            : base(options)
        {
        }

        public DbSet<TelaDeLogin.Models.Usuarios> Login { get; set; }
    }
}
