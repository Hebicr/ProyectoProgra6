//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoProgra6.Models
{
    using System;
    
    public partial class RetornaCantonesID_Result
    {
        public int id_Canton { get; set; }
        public int id_Provincia { get; set; }
        public string nombre { get; set; }
        public string Provincia { get; set; }
        public string usuarioCrea { get; set; }
        public Nullable<System.DateTime> fechaCrea { get; set; }
        public string usuarioModifica { get; set; }
        public Nullable<System.DateTime> fechaModifica { get; set; }
        public string vc_Estado { get; set; }
        public int id_CantonInec { get; set; }
    }
}
