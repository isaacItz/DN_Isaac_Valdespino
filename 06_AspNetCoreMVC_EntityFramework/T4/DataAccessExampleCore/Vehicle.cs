using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessExampleCore
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        public Make Make { get; set; }

        public Model Model { get; set; }

        [Required]
        public int Year { get; set; }
    }
}