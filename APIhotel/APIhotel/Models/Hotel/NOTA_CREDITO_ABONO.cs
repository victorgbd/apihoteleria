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
    
    public partial class NOTA_CREDITO_ABONO
    {
        public int ID_NCC_AB { get; set; }
        public int ID_RESERV_NCC_AB { get; set; }
        public int N_ABONO_NCC_AB { get; set; }
        public System.DateTime FECHA_ABONO_NCC_AB { get; set; }
        public decimal BALANCE_ANT_NCC_AB { get; set; }
        public decimal ABONO_NCC_AB { get; set; }
        public decimal BALANCE_ACT_NCC_AB { get; set; }
    
        public virtual reservacion reservacion { get; set; }
    }
}
