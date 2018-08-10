using Assesment.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assesment.Web.Controllers
{
    public class CommandeController : ApiController
    {
		[HttpGet]
		public IHttpActionResult GetCommandeById(int id)
		{
			return Ok();
		}

		[HttpGet]
		[Route("api/commande/personne/{personneId:int}")]
		public IHttpActionResult GetCommandeByPersonneId(int personneId)
		{
			return Ok();
		}

		[HttpGet]
		[Route("api/commande/{id:int}/personne/{personneId:int}")]
		public IHttpActionResult GetCommandeByPersonneId(int id, int personneId)
		{
			return Ok();
		}

		[HttpPost]
		public IHttpActionResult CreateOrder([FromBody] CreateOrderVM CreateOrder)
		{
			return Ok(CreateOrder);
		}

		[HttpPut]
		public	IHttpActionResult UpdateOrder(int id, [FromBody] UpdateOrderVM UpdateOrder)
		{
			return Ok(UpdateOrder);
		}
	}
}
