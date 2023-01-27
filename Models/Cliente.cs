using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Arnold.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ProductodeInteres { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public int documento_identidad { get; set; }
    }
}