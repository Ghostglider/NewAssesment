using System;
using Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestAssesment
{
	[TestClass]
	public class PersonControllerTest
	{
		private readonly Mock<IPersonRepository> _personRepository;

		public PersonControllerTest()
		{
			_personRepository = new Mock<IPersonRepository>;
		}

		[TestMethod]
		public void GetPersonByIdTest()
		{

		}
	}
}
