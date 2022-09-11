using System.ComponentModel.DataAnnotations;

namespace Desafio1_LF172473.Models
{
    public class Excursiones
    {
        public int Id { get; set; }
        public string Lugar { get; set; }
        public string Descripcion { get; set; }

        [Display(Name = "Costo por Persona")]
        [DataType(DataType.Currency)]
        public double CostoxPersona { get; set; }
        public string Img1 { get; set; }
        public string Img2 { get; set; }
        public string Img3 { get; set; }
        public string Recomendacion1 { get; set; }
        public string Recomendacion2 { get; set; }
        public string Recomendacion3 { get; set; }
        public string Pais { get; set; }

        [Display(Name = "Tipo de Destino")]
        public string TipoDestino { get; set; }

    }
}
