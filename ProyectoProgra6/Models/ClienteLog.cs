using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace ProyectoProgra6.Models
{
    public class ClienteLog
    {
        public int idCliente { get; set; }
        public string Cedula { get; set; }
        public int Genero { get; set; }
        public DateTime FechadeNacimiento { get; set; }
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
        public int id { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public int estado { get; set; }
        public int idRol { get; set; }
    }
}