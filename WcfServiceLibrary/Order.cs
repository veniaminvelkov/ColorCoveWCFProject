using ApplicationService.DTOs;
using ApplicationService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Order" in both code and config file together.
    public class Order : IOrder
    {
        private OrderManagementService service = new OrderManagementService();

        public List<OrderDTO> GetOrders()
        {
            return service.Get();
        }

        public OrderDTO GetOrderByID(int id)
        {
            return service.GetById(id);
        }

        public string PostOrder(OrderDTO orderDTO)
        {
            if (!service.Save(orderDTO))
                return "Order is not inserted";

            return "Order is inserted";
        }

        public string DeleteOrder(int id)
        {
            if (!service.Delete(id))
                return "Order is not deleted";

            return "Order is deleted";
        }
        public string Message()
        {
            return "The service is up and running.";
        }
    }
}
