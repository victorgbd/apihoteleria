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
    
    public partial class archivo
    {
        public string id_archivo { get; set; }
        public int id_tarchivo { get; set; }
        public string ruta_archivo { get; set; }
        public string comentario_01_archivo { get; set; }
        public string comentario_02_archivo { get; set; }
        public string estado_archivo { get; set; }
        public string CREADO_P_archivo { get; set; }
        public System.DateTime FECHA_C_archivo { get; set; }
        public string MOD_P_archivo { get; set; }
        public System.DateTime FECHA_M_archivo { get; set; }
    
        public virtual tipo_archivo tipo_archivo { get; set; }
    }
}
