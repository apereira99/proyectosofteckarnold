using Proyecto_Arnold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Arnold.DAL
{
    public class ListarProducto
    {
        public List<Producto> ObtenerProductos()
        {

            return new List<Producto>()
            {
                new Producto()
                {
                    NombreProducto = "Laptop HP Core i5",
                    Descripcion = "Laptop Ultima Generacion"
                },
            };
        }
    }
}