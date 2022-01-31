using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GymManager.Core.Entities
{
    public class MemberMembership
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public Membership Membership { get; set; }

        public Member Member { get; set; }

        public bool status { get; set; }
    }
}