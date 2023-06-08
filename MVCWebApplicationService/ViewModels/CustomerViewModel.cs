using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWebApplicationService.ViewModels
{
    public class CustomerViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Username { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [Required]
        [StringLength(15)]
        public string FirstName { get; set; }

        [StringLength(15)]
        public string LastName { get; set; }

        public CustomerViewModel() { }

        public CustomerViewModel(CustomerDTO customerDto)
        {
            Id = customerDto.Id;
            Username= customerDto.Username;
            Password= customerDto.Password;
            FirstName = customerDto.FirstName;
            LastName= customerDto.LastName;
        }
    }
}