using CarControl.Business.Abstract;
using CarControl.Entities.DataAccess;
using CarControl.Entities.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarControl.Business.Concrete
{
    public class CustomerManager : IBaseRepository<Customer>
    {
        private readonly CarContext _context;
        public CustomerManager(CarContext context)
        {
            _context = context;
        }
        public Customer Delete(int id, Customer entity)
        {
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
            return entity;
        }

        public Customer Get(int id)
        {
            return _context.Set<Customer>().SingleOrDefault();
        }

        public List<Customer> GetList()
        {
            return _context.Set<Customer>().ToList();
        }

        public Customer Save(Customer entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
            return entity;
        }

        public Customer Update(int id, Customer entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }
    }
}
