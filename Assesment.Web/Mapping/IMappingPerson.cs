using Assesment.Web.Models;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.Web.Mapping
{
	public interface IMappingPerson
	{
		Person MapingCreatePersonVMToPerson(CreatePersonVM createPersonVM);

		Person MapingUpdatePersonVMToPerson(UpdatePersonVM UpdatePersonVM);
	}
}
