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
    
    public partial class thabitacion_cama
    {
        public string id_t_hab_thc { get; set; }
        public string id_cama_thc { get; set; }
        public int Cantidad_camas { get; set; }
    
        public virtual cama cama { get; set; }
        public virtual tipo_habitacion tipo_habitacion { get; set; }
    }
}