//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoProgra6.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes()
        {
            this.AdicionesxCliente = new HashSet<AdicionesxCliente>();
            this.RegistrosPolizas = new HashSet<RegistrosPolizas>();
        }
    
        public int idCliente { get; set; }
        public string Cedula { get; set; }
        public string Genero { get; set; }
        public System.DateTime FechadeNacimiento { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string DireccionFisica { get; set; }
        public string TelefonoPrincipal { get; set; }
        public string TelefonoSecundario { get; set; }
        public string CorreoElectronico { get; set; }
        public int id_Provincia { get; set; }
        public int id_Canton { get; set; }
        public int id_Distrito { get; set; }
        public int id_Usuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdicionesxCliente> AdicionesxCliente { get; set; }
        public virtual Canton Canton { get; set; }
        public virtual Distrito Distrito { get; set; }
        public virtual Provincia Provincia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistrosPolizas> RegistrosPolizas { get; set; }
    }
}