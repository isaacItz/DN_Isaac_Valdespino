using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessExampleCore;

namespace DataAccessExampleEntityFramework
{
    public interface IColorsDataManager
    {
        
        void Insert(Color color);
        void Update(Color color);
        Color Get(int id);
        IList<Color> GetAll();
        void Delete(int id);
    }
}