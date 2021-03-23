using CarControl.Business.Abstract;
using CarControl.Entities.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CarControl.Business.Concrete
{
    public class CarManager : IBaseRepository<Car>
    {
        public Car Delete(int id, Car entity)
        {
            using (CarContext carContext = new CarContext())
            {
                var deletedEntity = carContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                carContext.SaveChanges();
                return entity;
            }
        }

        public Car Get(int id)
        {
            using (CarContext carContext = new CarContext())
            {
                return carContext.Set<Car>().SingleOrDefault();
            }
        }

        public List<Car> GetList()
        {
            using (CarContext carContext = new CarContext())
            {
                return carContext.Set<Car>().ToList();
            }
        }

        public Car Save(Car entity)
        {
            using (CarContext carContext = new CarContext())
            {
                var addedEntity = carContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                carContext.SaveChanges();
                return entity;
            }
        }

        public Car Update(int id, Car entity)
        {
            using (CarContext carContext = new CarContext())
            {
                var updatedEntity = carContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                carContext.SaveChanges();
                return entity;
            }
        }
    }
}
