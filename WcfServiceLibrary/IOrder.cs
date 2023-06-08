using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrder" in both code and config file together.
    [ServiceContract]
    public interface IOrder
    {
        [OperationContract]
        string Message();

        [OperationContract]
        List<OrderDTO> GetOrders();

        [OperationContract]
        OrderDTO GetOrderByID(int id);

        [OperationContract]
        string PostOrder(OrderDTO orderDTO);

        [OperationContract]
        string DeleteOrder(int id);
    }
}
