using Proyecto_Arnold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Proyecto_Arnold.Controllers
{
    public class ClienteController : ApiController
    {
        static Dictionary<int, Cliente> clientes = new Dictionary<int, Cliente>();

        //GET api/Asesor
        public IEnumerable<Cliente> Get()
        {
            return new List<Cliente>(clientes.Values);
        }


        //GET api/Asesor/5
        public Cliente Get(int id)
        {
            Cliente buscado;
            clientes.TryGetValue(id, out buscado);
            return buscado;

        }


        public bool Post([FromBody] Cliente cliente)
        {
            Cliente buscado;
            clientes.TryGetValue(cliente.IdCliente, out buscado);
            if (buscado == null)
            {
                clientes.Add(cliente.IdCliente, cliente);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
