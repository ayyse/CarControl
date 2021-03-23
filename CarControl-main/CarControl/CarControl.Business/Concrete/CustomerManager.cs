using CarControl.Business.Abstract;
using CarControl.Entities.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarControl.Business.Concrete
{
    public class CustomerManager : IBaseRepository<Customer>
    {
        public Customer Delete(int id, Customer entity)
        {
            using (CarContext carContext = new CarContext())
            {
                var deletedEntity = carContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                carContext.SaveChanges();
                return entity;
            }
        }

        public Customer Get(int id)
        {
            using (CarContext carContext = new CarContext())
            {
                return carContext.Set<Customer>().SingleOrDefault();
            }
        }

        public List<Customer> GetList()
        {
            using (CarContext carContext = new CarContext())
            {
                return carContext.Set<Customer>().ToList();
            }
        }

        public Customer Save(Customer entity)
        {
            using (CarContext carContext = new CarContext())
            {
                var addedEntity = carContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                carContext.SaveChanges();
                return entity;
            }
        }

        public Customer Update(int id, Customer entity)
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
