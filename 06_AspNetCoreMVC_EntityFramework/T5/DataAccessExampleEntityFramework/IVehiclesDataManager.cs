using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessExampleCore;

namespace DataAccessExampleEntityFramework
{
    public interface IVehiclesDataManager
    {
        void Insert(Vehicle vehicle);
        void Update(Vehicle vehicle);
        Vehicle Get(int id);
        IList<Vehicle> GetAll();
        void Delete(int id);
    }
}