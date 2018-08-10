using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assesment.Web.Mapping;
using Assesment.Web.Models;
using Data.Repositories;

namespace Assesment.Web.Controllers
{
    public class PersonneController : ApiController
    {
		private readonly IMappingPerson _mappingPerson;
		private readonly IPersonRepository _personRepository;

		public PersonneController(IMappingPerson mappingPerson, IPersonRepository personRepository)
		{
			_mappingPerson = mappingPerson;
			_personRepository = personRepository;
		}

		[HttpGet]
		public IHttpActionResult GetAllPersonne()
		{
			var result = _personRepository.GetAllPerson();
			return Ok(result);
		}

		[HttpGet]
		public IHttpActionResult GetPersonneById(int Id)
		{
			var result = _personRepository.GetPersonById(Id);
			return Ok(result);
		}

		[HttpPost]
		public IHttpActionResult CreatePersonne([FromBody] CreatePersonVM createPersonne)
		{
			int newId = _personRepository.CreatePerson(_mappingPerson.MapingCreatePersonVMToPerson(createPersonne));
			return Ok(newId);
		}

		[HttpPut]
		public IHttpActionResult UpdatePersonne(int Id, [FromBody] UpdatePersonVM updatePersonne)
		{
			_personRepository.UpdatePerson(Id,_mappingPerson.MapingUpdatePersonVMToPerson(updatePersonne));
			return Ok();
		}

		[HttpDelete]
		public IHttpActionResult DeletePersonne(int Id)
		{
			_personRepository.DeletePerson(Id);
			return Ok();
		}
    }
}
