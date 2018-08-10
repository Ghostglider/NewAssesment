using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Data.Entity.Migrations;

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
			_dbContext.Personns.Add(person);

			_dbContext.SaveChanges();

			return person.Id;
		}

		public void DeletePerson(int id)
		{
			var personToDeleted = _dbContext.Personns.FirstOrDefault(p => p.Id == id);

			if(personToDeleted != null)
			{ 
				_dbContext.Personns.Remove(personToDeleted);
				_dbContext.SaveChanges();
			}
		}

		public IEnumerable<Person> GetAllPerson()
		{
			return _dbContext.Personns.ToList();
		}

		public Person GetPersonById(int id)
		{
			Person personResult = _dbContext.Personns.FirstOrDefault(p => p.Id == id);

			return personResult;
			
		}

		public void UpdatePerson(int id, Person person)
		{
			var personToUpdated = _dbContext.Personns.FirstOrDefault(p => p.Id == id);

			int tempId = personToUpdated.Id;
			personToUpdated = person;
			personToUpdated.Id = tempId;


			_dbContext.Personns.AddOrUpdate(personToUpdated);

			_dbContext.SaveChanges();
		}
	}
}
