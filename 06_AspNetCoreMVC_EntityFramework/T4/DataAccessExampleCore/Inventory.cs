using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessExampleCore
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        public Vehicle Vehicle { get; set; }

        public Color Color { get; set; }

        [Required]
        public decimal Price { get; set; }

    }
}