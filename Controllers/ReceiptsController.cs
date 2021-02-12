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
    public class ReceiptsController : ApiController
    {
        EmbarquesLogic _embarques = new EmbarquesLogic();


        [Route("embarques/CountEmbarques")]
        [HttpGet]
        // GET: Users
        public IHttpActionResult GetEmbarquesCount()
        {

            var embarques = _embarques.CountReceipts();

            return Ok(embarques);
        }

        [Route("embarques/ListEmbarques")]
        [HttpGet]
        // GET: Users
        public IHttpActionResult GetEmbarques()
        {

            var embarques = _embarques.ListaEmbarques();

            return Ok(embarques);
        }


        [Route("embarques/ListEmbarquesTransito")]
        [HttpGet]
        // GET: Users
        public IHttpActionResult GetEmbarquesTransito()
        {

            var embarques = _embarques.ListaEmbarquesTransito();

            return Ok(embarques);
        }

        [Route("embarques/ListHistorial")]
        [HttpGet]
        // GET: Users
        public IHttpActionResult GetHistorial()
        {

            var embarques = _embarques.ListaHistorial();

            return Ok(embarques);
        }




        [Route("embarques/ReceiptDetail")]
        [HttpGet]
        // GET: Users
        public IHttpActionResult GetReceiptDetail(string codigo)
        {
            return Ok(_embarques.ReceiptDetail(codigo));
        }


        [Route("embarques/GiveReceiptInstructions")]
        [HttpGet]
        // GET: Users
        public IHttpActionResult GiveReceiptInstructios(int codigo)
        {
            _embarques.ReceiptInstructions(codigo);
            return Ok(true);
        }
    }
}
