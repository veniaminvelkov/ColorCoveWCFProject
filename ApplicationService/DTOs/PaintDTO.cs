using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
    public class PaintDTO : BaseDTO
    {
        [Required]
        public int PaintType { get; set; }

        [Required]
        [StringLength(20)]
        public string Brand { get; set; }

        [Required]
        public double Price { get; set; }
        
        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }
    }
}
