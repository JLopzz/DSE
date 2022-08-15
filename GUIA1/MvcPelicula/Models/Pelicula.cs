using System.Web;
using System.Data.Entity;

namespace MvcPelicula.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Lanzamiento { get; set; }
        public string Genero { get; set; }
        public decimal Precio { get; set; }

    }

    public class PeliDBContext : DbContext
    {
        public DbSet<Pelicula> Peliculas { get; set; }
    }
}
