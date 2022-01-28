using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessExampleCore
{
    public class Incentive
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal amount { get; set; }
    }
}