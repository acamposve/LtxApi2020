using Entidades.ViewModels;
using Logica;
using LtxApi2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LtxApi2020.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CiudadesController : ApiController
    {
        private DireccionesLogic dl = new DireccionesLogic();

        [Route("ciudades/ListCiudades")]
        [HttpGet]
        // GET: Users
        public IHttpActionResult GetCiudades()
        {

            var ciudades = dl.ListaCiudades();

            var ciudad = new List<CiudadesViewModel>();

            foreach (var item in ciudades)
            {

                CiudadesViewModel edto = new CiudadesViewModel
                {
                    id_ciudad = item.id_ciudad,
                    ciudad = item.ciudad,
                    id_estado = item.id_estado
                };
                ciudad.Add(edto);
            }
            return Ok(ciudad);
        }
    }
}
