using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoInterdisciplinar.Models
{
    public class ProjetoInterdisciplinarContext : DbContext
    {
        public ProjetoInterdisciplinarContext (DbContextOptions<ProjetoInterdisciplinarContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Vendedor { get; set; }
        public DbSet<SalesRecord> RecordeVendas { get; set; }

    }
}
