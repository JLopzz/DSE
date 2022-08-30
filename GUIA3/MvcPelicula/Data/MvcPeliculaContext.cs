using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcPelicula.Models;

namespace MvcPelicula.Data
{
    public class MvcPeliculaContext : DbContext
    {
        public MvcPeliculaContext (DbContextOptions<MvcPeliculaContext> options)
            : base(options)
        {
        }

        public DbSet<Pelicula> Pelicula { get; set; } = default!;
        public DbSet<Director> Director { get; set; } = default!;
    }
}
