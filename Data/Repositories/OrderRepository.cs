using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repositories
{
	public class OrderRepository : IOrderRepository
	{
		private readonly IAssesmentDbContext _dbContext;

		public OrderRepository(IAssesmentDbContext context)
		{
			_dbContext = context;
		}
		public int CreateOrder(Order order)
		{
			_dbContext.Orders.Add(order);

			_dbContext.SaveChanges();

			return order.Id;
		}

		public void DeleteOrder(int id)
		{
			var orderToDeleted = _dbContext.Orders.FirstOrDefault(o => o.Id == id);

			if (orderToDeleted != null)
			{
				_dbContext.Orders.Remove(orderToDeleted);
				_dbContext.SaveChanges();
			}
		}

		public IEnumerable<Order> GetAllOrder()
		{
			return _dbContext.Orders.Include("Person").ToList();
		}

		public Order GetOrderById(int id)
		{
			Order tempOrder = _dbContext.Orders.Include("Person").FirstOrDefault(o => o.Id == id);

			return tempOrder;
		}

		public IEnumerable<Order> GetOrderByPersonId(int personId)
		{
			var result = _dbContext.Orders.Include("Peron").Where(o => o.PersonId == personId).ToList();

			return result;
		}

		public Order GetOrderByPersonIdAndId(int id, int personId)
		{
			Order tempOrder = _dbContext.Orders.Include("Person").FirstOrDefault(o=> o.Id == id && o.PersonId == personId);

			return tempOrder;
		}

		public void UpdateOrder(int id, Order order)
		{
			var orderToUpdated = _dbContext.Orders.FirstOrDefault(o => o.Id == id);

			int tempId = orderToUpdated.Id;
			orderToUpdated = order;
			orderToUpdated.Id = tempId;


			_dbContext.Orders.AddOrUpdate(orderToUpdated);

			_dbContext.SaveChanges();
		}
	}
}
