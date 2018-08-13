using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class MemoryContext : IMemoryContext
	{
		public MemoryContext()
		{
		}

		public static List<Person> Persons = new List<Person>();

		public List<Person> GetPersons()
		{
			return Persons;
		}

		public void SetPersons(List<Person> value)
		{
			Persons = value;
		}
	}
}
