using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessExampleCore;

namespace DataAccessExampleEntityFramework
{
    public interface IQueriesExample
    {
        List<Make> GetMakes();

        List<Vehicle> GetVehiclesByPrice(decimal from, decimal to);
    }
}