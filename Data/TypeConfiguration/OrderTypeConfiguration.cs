using Data.Models;
using System.Data.Entity.ModelConfiguration;

namespace Data
{
	internal class OrderTypeConfiguration : EntityTypeConfiguration<Order>
	{
		public OrderTypeConfiguration()
		{
			// Key
			HasKey(o => o.Id);

			// Requiered
			Property(o => o.PersonId).IsRequired();
			Property(o => o.Item).IsRequired();
			Property(o => o.Quantity).IsRequired();

			// Mapping fields
			ToTable("Order");
			Property(o => o.Id).HasColumnName("Id");
			Property(o => o.PersonId).HasColumnName("PersonId");
			Property(o => o.Item).HasColumnName("Item");
			Property(o => o.Quantity).HasColumnName("Quantity");

			// Relation
			HasRequired(o => o.Person)
				.WithMany()
				.HasForeignKey(o => o.PersonId);
		}
	}
}