using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Customer
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public DateTime RegisterDate { get; set; }

        public Customer (string name, string lastName, DateTime registerDate)
        {
            this.Name = name;
            this.LastName = lastName;
            this.RegisterDate = registerDate;
        }
    }
}