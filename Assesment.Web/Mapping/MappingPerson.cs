using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assesment.Web.Models;
using Data.Models;

namespace Assesment.Web.Mapping
{
	public class MappingPerson : IMappingPerson
	{
		
		public Person MapingCreatePersonVMToPerson(CreatePersonVM createPersonVM)
		{
			Person person = new Person();

			person.Name = createPersonVM.Name;
			person.FirstName = createPersonVM.FirstName;
			person.Address = createPersonVM.Address;

			return person;
		}

		public Person MapingUpdatePersonVMToPerson(UpdatePersonVM UpdatePersonVM)
		{
			Person person = new Person();

			person.Name = UpdatePersonVM.Name;
			person.FirstName = UpdatePersonVM.FirstName;
			person.Address = UpdatePersonVM.Address;

			return person;
		}
	}
}