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
    
    public partial class alojamiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alojamiento()
        {
            this.habitacions = new HashSet<habitacion>();
        }
    
        public int id_alojamiento { get; set; }
        public int id_reserv_alojamiento { get; set; }
        public string ing_por_alojamiento { get; set; }
        public System.DateTime fecha_i_alojamiento { get; set; }
        public string sal_por_alojamiento { get; set; }
        public System.DateTime fecha_s_alojamiento { get; set; }
        public string estado_alojamiento { get; set; }
    
        public virtual reservacion reservacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<habitacion> habitacions { get; set; }
    }
}
