//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSI.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Etapas
    {
        public byte id { get; set; }
        public Nullable<System.DateTime> fecha_ini { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
        public Nullable<byte> N_Etapas { get; set; }
        public Nullable<short> id_Docu { get; set; }
    
        public virtual Documentos Documentos { get; set; }
    }
}