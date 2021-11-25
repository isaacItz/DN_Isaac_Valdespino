using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vehicle
    {
        public virtual void MakeASound()
        {
            Console.WriteLine("The vechicle makes beep beep");
        }
    }
}
