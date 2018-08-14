using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assesment.Web.Models;
using Data.Models;

namespace Assesment.Web.Mapping
{
	public class MappingOrder : IMappingOrder
	{
		public Order MapingCreateOrderVMToOrder(CreateOrderVM createOrderVM)
		{
			Order order = new Order();

			order.PersonId = createOrderVM.PersonId;
			order.Item = createOrderVM.Item;
			order.Quantity = createOrderVM.Quantity;

			return order;
		}

		public Order MapingUpdateOrderVMToOrder(UpdateOrderVM UpdateOrderVM)
		{
			Order order = new Order();

			order.PersonId = UpdateOrderVM.PersonId;
			order.Item = UpdateOrderVM.Item;
			order.Quantity = UpdateOrderVM.Quantity;

			return order;
		}
	}
}