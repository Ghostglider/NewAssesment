using System;
using Assesment.Web.Mapping;
using Assesment.Web.Models;
using Data;
using Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAssesment
{
	[TestClass]
	public class TestMappingPerson
	{
		private readonly IMappingPerson _mappingPerson;

		public TestMappingPerson()
		{
			_mappingPerson = new MappingPerson();
		}
		[TestMethod]
		public void MapingCreatePersonVMToPersonTest()
		{
			//Arrange
			CreatePersonVM createPersonVM = new CreatePersonVM();

			createPersonVM.Name = "TestNom";
			createPersonVM.FirstName = "testPrenom";
			createPersonVM.Address = "testAdresse";

			//Act
			var result = _mappingPerson.MapingCreatePersonVMToPerson(createPersonVM);

			//Assert
			Assert.AreEqual(result.FirstName, createPersonVM.FirstName);
			Assert.AreEqual(result.Id, 0);

		}
	}
}
