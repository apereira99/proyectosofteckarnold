using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Arnold.Models
{
    public class Asesor
    {
        public int IdAsesor { get; set; }
        public string NombreAsesor { get; set; }
        public string NombreProducto  { get; set; }
        public int edad { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
    }
}