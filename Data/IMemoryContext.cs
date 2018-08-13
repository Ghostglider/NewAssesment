using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public interface IMemoryContext
	{
		List<Person> GetPersons();
		void SetPersons(List<Person> value);
	}
}
