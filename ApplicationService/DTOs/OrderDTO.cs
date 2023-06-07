using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
    public class OrderDTO : BaseDTO
    {
        public int CustomerId { get; set; }

        public int PaintId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Employee OrderedBy { get; set; }

        [ForeignKey(nameof(PaintId))]
        public Paint PaintOrdered { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
