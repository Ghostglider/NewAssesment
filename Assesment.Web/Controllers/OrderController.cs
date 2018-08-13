using Assesment.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assesment.Web.Controllers
{
    public class OrderController : ApiController
    {
		[HttpGet]
		public IHttpActionResult GetOrderById(int id)
		{
			return Ok();
		}

		[HttpGet]
		[Route("api/order/person/{personId:int}")]
		public IHttpActionResult GetOrderByPersonneId(int personId)
		{
			return Ok();
		}

		[HttpGet]
		[Route("api/Order/{id:int}/person/{personId:int}")]
		public IHttpActionResult GetOneOrderByPersonneId(int id, int personId)
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
