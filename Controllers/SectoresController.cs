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
    public class SectoresController : ApiController
    {
        SectoresLogic _sectores = new SectoresLogic();
        [Route("sectores/ListSectores")]
        [HttpGet]
        // GET: Users
        public IHttpActionResult GetAddress()
        {
            return Ok(_sectores.ListaSectores());
        }
    }
}
