using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assesment.Web.Models
{
	public class UpdateOrderVM
	{
		public int PersonneId { get; set; }

		public string Article { get; set; }

		public int Quantite { get; set; }
	}
}