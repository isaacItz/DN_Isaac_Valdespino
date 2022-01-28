using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessExampleCore
{
    public class VehicleIncentive
    {

        public int VehicleId { get; set; }
        public int IncentiveId { get; set; }

        public Incentive Incentive { get; set; }

        public Vehicle Vehicle { get; set; }

        [Required]
        public DateTime ValidTill { get; set; }
    }
}