using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessExampleCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessExampleEntityFramework
{
    public class QueriesExample : IQueriesExample
    {

        private readonly VehiclesDataContext _dataContext;
        public QueriesExample(VehiclesDataContext dataContext) {
            _dataContext = dataContext;
        }
        public List<Make> GetMakes()
        {
            List<Make> makes = _dataContext.Makes.Include(x => x.Vehicles).OrderBy(x => x.Country).ToList();

            return makes;
        }

        public List<Vehicle> GetVehiclesByPrice(decimal _from, decimal _to) {
            //List<Vehicle> vehicles = _dataContext.Inventories.Where(x => 
            //x.Price  >= from && x.Price <= to).Select(x => x.Vehicle).ToList();
            List<Vehicle> vehicles = (from i in _dataContext.Inventories
            join v in _dataContext.Vehicles on i.Vehicle.Id equals v.Id
            where i.Price >= _from && i.Price <= _to
            select v).ToList();

            return vehicles;
        }

    }
}