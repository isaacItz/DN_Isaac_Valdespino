using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessExample.Entities
{
    public class CompanyCreationResult
    {
        public int CompanyId {get; set;}

        public int AdminId {get; set;}

        public int UserId {get; set;}

        public override string ToString()
        {
            return $"CompanyId: {CompanyId}, AdminId: {AdminId}, UserId: {UserId}";
        }
    }
}