//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Permisos
    {
        public int Id { get; set; }
        public int Grupo_Id { get; set; }
        public string Modificar { get; set; }
        public string Editar { get; set; }
        public string Eliminar { get; set; }
        public bool Activo { get; set; }
    
        public virtual Catalogos Catalogos { get; set; }
    }
}
