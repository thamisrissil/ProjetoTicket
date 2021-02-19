using ProjetoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoWeb.Controllers
{
    public class EstadoController : ApiController
    {

        [Route("api/Estad")]
        [HttpGet]
        public IHttpActionResult GetAll(string search)
        {
            return Ok("fodase");
        }

    }
}
