using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repositories
{
	public class PersonRepository : IPersonRepository
	{
		private readonly IAssesmentDbContext _dbContext;

		public PersonRepository(IAssesmentDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public int CreatePerson(Person person)
		{
			_dbContext.Personnes.Add(person);

			_dbContext.SaveChanges();

			return person.Id;
		}

		public void DeletePerson(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Person> GetAllPerson()
		{
			throw new NotImplementedException();
		}

		public Person GetPersonById(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdatePerson(int id, Person person)
		{
			throw new NotImplementedException();
		}
	}
}
