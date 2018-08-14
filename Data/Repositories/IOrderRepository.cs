using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
	public interface IOrderRepository
	{
		Order GetOrderById(int id);

		IEnumerable<Order> GetOrderByPersonId(int personId);

		Order GetOrderByPersonIdAndId(int id, int personId);

		IEnumerable<Order> GetAllOrder();

		int CreateOrder(Order order);

		void UpdateOrder(int id, Order order);

		void DeleteOrder(int id);
	}
}
