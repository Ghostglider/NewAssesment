using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public interface IAssesmentDbContext
	{
		DbSet<Person> Personns { get; set; }

		int SaveChanges();
	}
}
