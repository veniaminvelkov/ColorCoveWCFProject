using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Customer : BasePersonEntity
    {
        //-Date registered <DateTime>

        [Required]
        public DateTime DateRegistered { get; set; }
    }
}
