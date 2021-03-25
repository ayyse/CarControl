using CarControl.Entities.Abstract;
using CarControl.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarControl.Entities.Concrete
{
    public class UnitofWork : IUnitofWork
    {
        private readonly CarContext _context;
        public UnitofWork(CarContext context)
        {
            _context = context;
            carRepository = new CarRepository(_context);
            customerRepository = new CustomerRepository(_context);
        }
        public ICarRepository carRepository { get; set; }
        public ICustomerRepository customerRepository { get; set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
