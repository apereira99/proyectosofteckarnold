using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Arnold.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int cantidadProductos { get; set; } 
        public string marca { get; set; }
        public string modelo { get; set; }
        
    }
}