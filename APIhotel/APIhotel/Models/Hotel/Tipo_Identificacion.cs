//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIhotel.Models.Hotel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipo_Identificacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_Identificacion()
        {
            this.Terceroes = new HashSet<Tercero>();
        }
    
        public string Id_Tipo_Ident { get; set; }
        public string Descr_Tipo_Ident { get; set; }
        public string Estado_Tipo_Ident { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tercero> Terceroes { get; set; }
    }
}
