using System;
using Assesment.Web.Controllers;
using Assesment.Web.Mapping;
using Data.Models;
using Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Http.ModelBinding;
using System.Web.Http.Results;
using Microsoft.CSharp;

namespace TestAssesment
{
	[TestClass]
	public class PersonControllerTest
	{
		private readonly Mock<IPersonRepository> _personRepository;
		private readonly IMappingPerson _mappingPerson;
		private readonly PersonneController _controller;

		public PersonControllerTest()
		{
			_personRepository = new Mock<IPersonRepository>();
			_mappingPerson = new MappingPerson();

			_controller = new PersonneController(_mappingPerson, _personRepository.Object);
		}

		[TestMethod]
		public void GetPersonByIdTest()
		{
			var person = new Person { Id = 1, Name="ROCHET", FirstName="Frédéric", Address="Ici" };

			_personRepository.Setup(stub => stub.GetPersonById(1)).Returns(person);

			dynamic result = _controller.GetPersonneById(1);
			object content = result.Content;

			Assert.AreEqual(person, content);

		}
	}
}
