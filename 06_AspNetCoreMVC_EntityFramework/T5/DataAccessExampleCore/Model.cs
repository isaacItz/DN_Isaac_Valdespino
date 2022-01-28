using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessExampleCore
{
    public class Model
    {

        public Model(){
            Vehicles = new List<Vehicle>();
        }

        [Key]
        public int Id {get; set;}

        [Required]
        [StringLength(500)]
        public string Modelname{get; set;}

        public List<Vehicle> Vehicles { get; set; }

        [Required]
        public int FirstProductionYear{get; set;}

    }
}