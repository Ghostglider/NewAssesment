using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.TypeConfiguration
{
	internal class PersonneTypeConfiguration : EntityTypeConfiguration<Person>
	{
		public PersonneTypeConfiguration()
		{ 
			// Key
			HasKey(p => p.Id);

			// Requiered
			Property(p => p.Name).IsRequired();
			Property(p => p.FirstName).IsRequired();

			// Mapping fields
			ToTable("Person");
			Property(p => p.Id).HasColumnName("Id");
			Property(p => p.Name).HasColumnName("Name");
			Property(p => p.FirstName).HasColumnName("FirstName");
			Property(p => p.Address).HasColumnName("Address");

		}
	}
}
