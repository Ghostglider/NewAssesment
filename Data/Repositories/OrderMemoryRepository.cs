using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repositories
{
	public class OrderMemoryRepository : IOrderRepository
	{
		private readonly IMemoryContext _context;

		public OrderMemoryRepository(IMemoryContext context)
		{
			_context = context;
		}

		public int CreateOrder(Order order)
		{
			order.Id = _context.GetOrders().Count == 0 ? 1 : _context.GetOrders().Max(p => p.Id) + 1;
			order.Person = _context.GetPersons().FirstOrDefault(p => p.Id == order.PersonId);
			_context.GetOrders().Add(order);

			return order.Id;
		}

		public void DeleteOrder(int id)
		{
			Order tempOrder = _context.GetOrders().FirstOrDefault(p => p.Id == id);
			_context.GetOrders().Remove(tempOrder);
		}

		public IEnumerable<Order> GetAllOrder()
		{ 
			return _context.GetOrders();
		}

		public Order GetOrderById(int id)
		{
				return _context.GetOrders().FirstOrDefault(o => o.Id == id);
		}

		public IEnumerable<Order> GetOrderByPersonId(int personId)
		{
			var result = _context.GetOrders().Where(o => o.PersonId == personId);
			return result;
		}

		public Order GetOrderByPersonIdAndId(int id, int personId)
		{
			return _context.GetOrders().FirstOrDefault(o => o.Id == id && o.PersonId == personId);
		}

		public void UpdateOrder(int id, Order order)
		{
			int tempIndex = _context.GetOrders().FindIndex(o => o.Id == id);

			_context.GetOrders()[tempIndex].Item = order.Item;
			_context.GetOrders()[tempIndex].Quantity = order.Quantity;
			_context.GetOrders()[tempIndex].PersonId = order.PersonId;
			_context.GetOrders()[tempIndex].Person = _context.GetPersons().FirstOrDefault(p => p.Id == order.PersonId);


		}
	}
}
