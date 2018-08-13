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
			person.Id = _context.GetPersons().Count == 0 ? 1 : _context.GetPersons().Max(p => p.Id) + 1;
			_context.GetPersons().Add(person);

			return person.Id;
		}

		public void DeletePerson(int id)
		{
			Person tempPerson = _context.GetPersons().FirstOrDefault(p => p.Id == id);

			_context.GetPersons().Remove(tempPerson);
		}

		public IEnumerable<Person> GetAllPerson()
		{
			return _context.GetPersons();
		}

		public Person GetPersonById(int id)
		{
			Person result = _context.GetPersons().FirstOrDefault(p => p.Id == id);
			return result;
		}

		public void UpdatePerson(int id, Person person)
		{
			int tempindex = _context.GetPersons().FindIndex(p => p.Id == id);
			_context.GetPersons()[tempindex].Name = person.Name;
			_context.GetPersons()[tempindex].FirstName = person.FirstName;
			_context.GetPersons()[tempindex].Address = person.Address;
			
		}
	}
}
