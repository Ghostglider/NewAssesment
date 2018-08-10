﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assesment.Web.Models;

namespace Assesment.Web.Controllers
{
    public class PersonneController : ApiController
    {

		[HttpGet]
		public IHttpActionResult GetAllPersonne()
		{
			return Ok();
		}

		[HttpGet]
		public IHttpActionResult GetPersonneById(int Id)
		{
			string[] str = new string[]{ "Test", "Test2", "encore un test" };
			return Ok(str);
		}

		[HttpPost]
		public IHttpActionResult CreatePersonne([FromBody] CreatePersonVM createPersonne)
		{
			return Ok(createPersonne);
		}

		[HttpPut]
		public IHttpActionResult UpdatePersonne(int Id, [FromBody] UpdatePersonVM updatePersonne)
		{

			return Ok(updatePersonne);
		}

		[HttpDelete]
		public IHttpActionResult DeletePersonne(int Id)
		{
			return Ok();
		}
    }
}
