using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessExampleCore
{
    public class Color
    {

        public Color()  {
            Inventories = new List<Inventory>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [StringLength(5)]
        [Required]
        public string Code { get; set; }

        public List<Inventory> Inventories { get; set; }
    }
}