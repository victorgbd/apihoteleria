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
    
    public partial class tipo_archivo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipo_archivo()
        {
            this.archivoes = new HashSet<archivo>();
        }
    
        public int id_t_archivo { get; set; }
        public string descr_t_archivo { get; set; }
        public string estado_t_archivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<archivo> archivoes { get; set; }
    }
}
