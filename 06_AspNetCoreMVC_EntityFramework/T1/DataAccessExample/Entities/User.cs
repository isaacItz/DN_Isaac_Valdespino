using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessExample.Entities
{
    public class User
    {
        public int Id {get; set;}

        public string? UserName {get; set;}

        public string? Email {get; set;}

        public int CompanyId {get; set;}
    }
}