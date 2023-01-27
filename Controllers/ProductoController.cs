using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using Proyecto_Arnold.Models;

namespace Proyecto_Arnold.Controllers
{
    public class ProductoController : ApiController
    {

        static Dictionary<int, Producto> productos = new Dictionary<int, Producto>();

        //GET api/Producto
        public IEnumerable<Producto> Get()
        {
            return new List<Producto>(productos.Values);
        }



        //GET api/Producto/5
        public Producto GetBuscar(int id)
        {
            Producto buscado;
            productos.TryGetValue(id, out buscado);
            return buscado;

        }



        public bool Post([FromBody] Producto producto)
        {
            Producto buscado;
            productos.TryGetValue(producto.IdProducto, out buscado);
            if (buscado == null)
            {
                productos.Add(producto.IdProducto, producto);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
