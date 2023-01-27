using Proyecto_Arnold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Proyecto_Arnold.Controllers
{
    public class AsesorController : ApiController
    {
        static Dictionary<int, Asesor> asesores = new Dictionary<int, Asesor>();

        //GET api/Asesor
        public IEnumerable<Asesor> Get()
        {
            return new List<Asesor>(asesores.Values);
        }


        //GET api/Asesor/5
        public Asesor Get(int id)
        {
            Asesor buscado;
            asesores.TryGetValue(id, out buscado);
            return buscado;

        }


        public bool Post([FromBody] Asesor asesor)
        {
            Asesor buscado;
            asesores.TryGetValue(asesor.IdAsesor, out buscado);
            if (buscado == null)
            {
                asesores.Add(asesor.IdAsesor, asesor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
