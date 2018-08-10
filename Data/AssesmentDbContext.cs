using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AssesmentDbContext : DbContext, IAssesmentDbContext
    {
		static AssesmentDbContext()
		{
			Database.SetInitializer<DbContext>(null);
		}

		public AssesmentDbContext() : base("AssesmentDbContext")
		{
			Configuration.LazyLoadingEnabled = false;
		}

		public DbSet<Person> Personnes { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new PersonneTypeConfiguration());
		}
	}
}
