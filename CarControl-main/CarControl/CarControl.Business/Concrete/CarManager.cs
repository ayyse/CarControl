using CarControl.Business.Abstract;
using CarControl.Entities.DataAccess;
using CarControl.Entities.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CarControl.Business.Concrete
{
    public class CarManager : IBaseRepository<Car>
    {
        private readonly CarContext _context;
        public CarManager(CarContext context)
        {
            _context = context;
        }
        public Car Delete(int id, Car entity)
        {
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
            return entity;
        }

        public Car Get(int id)
        {
            Car data = _context.Cars.Find(id);
            return data;
            //return _context.Set<Car>().SingleOrDefault();
        }

        public List<Car> GetList()
        {
            return _context.Set<Car>().ToList();
        }

        public Car Save(Car entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
            return entity;
        }

        public Car Update(int id, Car entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }
    }
}
