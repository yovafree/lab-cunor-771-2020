//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcEjemplo1.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public partial class comentario
    {
        public int cod_comentario { get; set; }
        public string autor { get; set; }
        [AllowHtml]
        public string comentario1 { get; set; }
        public string correo_electronico { get; set; }
        public Nullable<int> cod_articulo { get; set; }
        public Nullable<System.DateTime> fec_creacion { get; set; }
    
        public virtual articulo articulo { get; set; }
    }
}
