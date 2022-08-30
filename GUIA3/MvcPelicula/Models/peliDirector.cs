namespace MvcPelicula.Models
{
    public class peliDirector
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime? Lanzamiento { get; set; }
        public string Genero { get; set; }
        public string Productor { get; set; }
        public string Director { get; set; }
    }
}
