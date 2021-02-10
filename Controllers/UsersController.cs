using Entidades.ViewModels;
using Logica;
using LtxApi2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Security;

namespace LtxApi2020.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class UsersController : ApiController
    {
        private UserLogic UL = new UserLogic();
        [Route("user")]
        [HttpGet]
        //GET: Users
        public IHttpActionResult GetUserByEmail( string usuario)
        {
            return Ok(UL.GetUser(usuario));
        }

        [Route("users/authenticate")]
        [HttpPost]
        // GET: Users
        public IHttpActionResult Authenticate([FromBody] User usuario)
        {

            UsuarioViewModel uvm = new UsuarioViewModel();

            uvm.Email = usuario.username;
            uvm.AccessPassword = usuario.password;


            return Ok(UL.GetUsuarioLogin(uvm));
        }
    }
}