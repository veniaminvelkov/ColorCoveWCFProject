using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class BasePersonEntity
    {
        /*
         * -ID <int>
	        -username <string>
	        -password <string>
	        -First name <string>
	        -Last name <string>
	        -Is soft deleted <bool>
         */

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
        public string? LastName { get; set; }

        [Required]
        public bool IsSoftDeleted { get; set; }
    }
}
