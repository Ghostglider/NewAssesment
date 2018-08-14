using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
	public class Order
	{
		public int Id { get; set; }

		public int PersonId { get; set; }

		public Person Person { get; set; }

		public string Item { get; set; }

		public int Quantity { get; set; }
	}
}
