using Entidades.ViewModels;
using Logica;
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
    public class DireccionesController : ApiController
    {

        DireccionesLogic _direcciones = new DireccionesLogic();
        [Route("direcciones/ListDirecciones")]
        [HttpGet]
        // GET: Users
        public IHttpActionResult GetAddress()
        {
            return Ok(_direcciones.ListaDirecciones());
        }


        [Route("direcciones/AgregarDireccion")]
        [HttpPost]
        public IHttpActionResult AddAddress([FromBody] AddressFromAngular avm)
        {

            _direcciones.AgregarDireccion(avm);
            return Ok(true);
        }


        [Route("direcciones/DireccionxId")]
        [HttpGet]
        public IHttpActionResult AddressxId(string id)
        {
            return Ok(_direcciones.DireccionxId(id));
        }


        [Route("direcciones/UpdateAddress")]
        [HttpPost]
        public IHttpActionResult UpdateAddress([FromBody] AddressFromAngular avm)
        {
            _direcciones.UpdateAddress(avm);
            return Ok(true);
        }


        [Route("direcciones/DeleteAddress")]
        [HttpGet]
        public IHttpActionResult DeleteAddress(string id)
        {
            _direcciones.DeleteAddress(id);
            return Ok(true);
        }
    }
}
