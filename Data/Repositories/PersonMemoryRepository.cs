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
			person.Id = _context.Persons().Count == 0 ? 1 : _context.Persons().Max(p => p.Id) + 1;
			_context.Persons().Add(person);

			return person.Id;
		}

		public void DeletePerson(int id)
		{
			Person tempPerson = _context.Persons().FirstOrDefault(p => p.Id == id);

			_context.Persons().Remove(tempPerson);
		}

		public IEnumerable<Person> GetAllPerson()
		{
			return _context.Persons();
		}

		public Person GetPersonById(int id)
		{
			Person result = _context.Persons().FirstOrDefault(p => p.Id == id);
			return result;
		}

		public void UpdatePerson(int id, Person person)
		{
			int tempindex = _context.Persons().FindIndex(p => p.Id == id);
			_context.Persons()[tempindex].Name = person.Name;
			_context.Persons()[tempindex].FirstName = person.FirstName;
			_context.Persons()[tempindex].Address = person.Address;
			
		}
	}
}
