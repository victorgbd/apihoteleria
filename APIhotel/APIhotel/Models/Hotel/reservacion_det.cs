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
    
    public partial class reservacion_det
    {
        public int id_reservacion_det { get; set; }
        public string id_thab_reserv_det { get; set; }
        public int cant_reserv_det { get; set; }
    
        public virtual reservacion reservacion { get; set; }
        public virtual tipo_habitacion tipo_habitacion { get; set; }
    }
}
