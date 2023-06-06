using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Employee : BasePersonEntity
    {
        //-Date hired <DateTime>
        //-Salary<double>

        [Required]
        public DateTime DateHired { get; set; }

        [Required]
        public double Salary { get; set; }
    }
}
