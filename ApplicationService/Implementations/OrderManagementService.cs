using ApplicationService.DTOs;
using Data.Entities;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Implementations
{
    public class OrderManagementService
    {
        public List<OrderDTO> Get()
        {
            List<OrderDTO> orderDTO = new List<OrderDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.OrderRepository.Get())
                {
                    orderDTO.Add(new OrderDTO
                    {
                        Id = item.Id,
                        CustomerId= item.CustomerId,
                        PaintId= item.PaintId,
                        OrderedBy = item.OrderedBy,
                        PaintOrdered = item.PaintOrdered,
                        Quantity = item.Quantity
                    });
                }
            }
            return orderDTO;
        }
        public OrderDTO GetById(int id)
        {
            OrderDTO orderDTO = new OrderDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Order order = unitOfWork.OrderRepository.GetByID(id);
                if (order != null)
                {
                    orderDTO = new OrderDTO
                    {
                        Id = order.Id,
                        CustomerId = order.CustomerId,
                        PaintId = order.PaintId,
                        OrderedBy = order.OrderedBy,
                        PaintOrdered = order.PaintOrdered,
                        Quantity = order.Quantity
                    };
                }
            }
            return orderDTO;
        }
        public bool Save(OrderDTO orderDTO)
        {
            Order order = new Order
            {
                Id = orderDTO.Id,
                CustomerId = orderDTO.CustomerId,
                PaintId = orderDTO.PaintId,
                OrderedBy = orderDTO.OrderedBy,
                PaintOrdered = orderDTO.PaintOrdered,
                Quantity = orderDTO.Quantity
            };

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.OrderRepository.Insert(order);
                unitOfWork.Save();
            }
            return true;
        }
        public bool Delete(int id)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Order order = unitOfWork.OrderRepository.GetByID(id);
                unitOfWork.OrderRepository.Delete(order);
                unitOfWork.Save();
            }
            return true;
        }
    }
}
