using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TpMVC.Models;

namespace TpMVC.Data
{
    public class InfnetDbContext : DbContext
    {
        public InfnetDbContext (DbContextOptions<InfnetDbContext> options)
            : base(options)
        {
        }

        public DbSet<TpMVC.Models.Computador> Computador { get; set; } = default!;
    }
}
