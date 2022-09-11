using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Desafio1_LF172473.Models;

namespace Desafio1_LF172473.Data
{
    public class ExcursionesContext : DbContext
    {
        public ExcursionesContext (DbContextOptions<ExcursionesContext> options)
            : base(options)
        {
        }

        public DbSet<Desafio1_LF172473.Models.Excursiones> Excursiones { get; set; } = default!;
    }
}
