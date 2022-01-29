using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Core.Entities
{
    public class Member
    {

        public Member() {
            MemberMemberships = new List<MemberMembership>();
        }

        public int Id { get; set; }
        
        [StringLength(15)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [StringLength(20)]
        [Required]
        public string LastName { get; set; }
        
        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [Required]
        public DateTime RegisteredDate { get; set; }

        public City City { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public bool AllowNewsLetter { get; set; }

        public List<MemberMembership>? MemberMemberships { get; set; }

    }
}