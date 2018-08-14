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

		public static List<Person> Person = new List<Person>();

		public List<Person> Persons()
		{
			return Person;
		}

		
	}
}
