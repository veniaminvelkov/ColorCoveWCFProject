using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWebApplicationService.ViewModels
{
    public class PaintViewModel
    {
        [Key]
        public int Id { get; set; }

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

        public PaintViewModel(){}

        public PaintViewModel(PaintDTO paintDTO)
        {
            paintDTO.Id = Id;
            paintDTO.PaintType = PaintType;
            paintDTO.Brand = Brand;
            paintDTO.Price = Price;
            paintDTO.ExpiryDate = ExpiryDate;
            paintDTO.IsAvailable = IsAvailable;
            paintDTO.Quantity = Quantity;
        }
    }
}