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
    
    public partial class DIRECCION
    {
        public string id_Tercero_Direccion { get; set; }
        public string id_mun_Direccion { get; set; }
        public string Direccion1 { get; set; }
        public string TIPO_DIRECCION { get; set; }
        public int N_LINEA_DIRECCION { get; set; }
        public string ESTADO_DIRECCION { get; set; }
    
        public virtual MUNICIPIO MUNICIPIO { get; set; }
        public virtual Tercero Tercero { get; set; }
    }
}
