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
    
    public partial class oferta_det_03
    {
        public string id_oferta_det03 { get; set; }
        public int c_ini_aloj_det03 { get; set; }
        public int c_fin_aloj_det03 { get; set; }
        public decimal descuento_det03 { get; set; }
    
        public virtual Oferta Oferta { get; set; }
    }
}