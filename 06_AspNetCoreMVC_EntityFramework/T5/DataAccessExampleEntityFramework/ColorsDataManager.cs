using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessExampleCore;

namespace DataAccessExampleEntityFramework
{
    public class ColorsDataManager : IColorsDataManager
    {
        private readonly VehiclesDataContext _dataContext;
        public ColorsDataManager(VehiclesDataContext dataContext) {
            _dataContext = dataContext;
        }
        public void Insert(Color color)
        {
            _dataContext.Colors.Add(color);
            _dataContext.SaveChanges();
        }

        public void Update(Color color)
        {
            var entity = _dataContext.Colors.Find(color.Id);
            entity.Code = color.Code;
            entity.Name = color.Name;

            _dataContext.SaveChanges();
        }
        public Color Get(int id)
        {
            var entity = _dataContext.Colors.Find(id);
            return entity;
        }

        public IList<Color> GetAll()
        {
            var list = _dataContext.Colors.ToList();
            return list;
        }

        public void Delete(int id)
        {
            var entity = _dataContext.Colors.Find(id);
            _dataContext.Colors.Remove(entity);
            
            _dataContext.SaveChanges();
        }
    }
}