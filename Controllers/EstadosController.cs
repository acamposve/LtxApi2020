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
    public class EstadosController : ApiController
    {
        DireccionesLogic dl = new DireccionesLogic();
        [Route("estados/ListEstados")]
        [HttpGet]
        // GET: Users
        public IHttpActionResult GetEstados()
        {

            var estados = dl.ListaEstados();

            var estado = new List<EstadosViewModel>();

            foreach (var item in estados)
            {

                EstadosViewModel edto = new EstadosViewModel
                {
                    id_estado = item.id_estado,
                    estado = item.estado
                };
                estado.Add(edto);
            }
            return Ok(estado);
        }
    }
}
