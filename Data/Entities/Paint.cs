using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Paint
    {
		/*
    -ID <int>
	-Paint type: <int>
		-Default (Unspecified) [0]
		-Oil paint [1]
		-Acrylic paint [2]
		-Watercolor paint [3]
		-Gouache [4]
		-Error [-1 or any other number]
	-Brand <string>
	-Price <double>
	-Aditional info <string>
	-Is available <bool>
	-Expiry date <DateTime>
         */
		[Key]
        public int Id { get; set; }

		[Required]
		public int PaintType { get; set; }

		[Required]
		[StringLength(20)]
		public string Brand { get; set; }

		[Required]
		public double Price { get; set; }

        [StringLength(120)]
        public string? AdditionalInfo { get; set; }

		[Required]
		public bool IsAvailable { get; set; }

		[Required]
		public int Quantity { get; set; }

		[Required]
		public DateTime ExpiryDate { get; set; }

	}
}
