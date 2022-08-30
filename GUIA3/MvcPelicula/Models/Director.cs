using System;
using System.ComponentModel.DataAnnotations;

public class Director
{
    public int Id { get; set; }
    public int IdPelicula { get; set; }

    [StringLength(60, MinimumLength = 3)]
    public string Nombre { get; set; }

}
