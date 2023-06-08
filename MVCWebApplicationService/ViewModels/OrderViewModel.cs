using ApplicationService.DTOs;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWebApplicationService.ViewModels
{
    public class OrderViewModel
    {
        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int PaintId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer OrderedBy { get; set; }

        [ForeignKey(nameof(PaintId))]
        public Paint PaintOrdered { get; set; }

        [Required]
        public int Quantity { get; set; }

        public OrderViewModel() { }

        public OrderViewModel(OrderDTO orderDTO)
        {
            Id = orderDTO.Id;
            CustomerId = orderDTO.CustomerId;
            PaintId = orderDTO.PaintId;
            OrderedBy = orderDTO.OrderedBy;
            PaintOrdered = orderDTO.PaintOrdered;
            Quantity = orderDTO.Quantity;
        }
    }
}