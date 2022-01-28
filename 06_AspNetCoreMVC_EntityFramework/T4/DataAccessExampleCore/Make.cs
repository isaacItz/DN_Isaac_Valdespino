using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessExampleCore
{
    public class Make
    {

        public Make() {
            Vehicles = new List<Vehicle>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string MakeName { get; set; }

        [StringLength(100)]
        [Required]
        public string Country { get; set; }

        public List<Vehicle> Vehicles { get; set; }

    }
}