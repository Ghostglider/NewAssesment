using Data.Models;
using Data.TypeConfiguration;
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

		public DbSet<Person> Personns { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new PersonneTypeConfiguration());
		}
	}
}
