using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Order
    {

        /*
         -ID<int>
	-Ordered By<Customer>
	-Paint ordered<Paint>
	-Quantity<int>
	-Date ordered<DateTime>
	-Order Details<string>
         */

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

        [Required]
        public DateTime DateOrdered { get; set; }

        public string OrderDetails { get; set; }
    }
}
