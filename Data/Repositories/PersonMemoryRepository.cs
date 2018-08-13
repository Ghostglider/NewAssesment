using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repositories
{
	public class PersonMemoryRepository : IPersonRepository
	{
		private readonly IMemoryContext _context;

		public PersonMemoryRepository(IMemoryContext context)
		{
			_context = context;
		}

		public int CreatePerson(Person person)
		{
			person.Id = _context.GetPersons().Count == null ? 1 : _context.GetPersons().Max(p => p.Id) + 1;
			_context.GetPersons().Add(person);

			return person.Id;
		}

		public void DeletePerson(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Person> GetAllPerson()
		{
			return _context.GetPersons();
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
