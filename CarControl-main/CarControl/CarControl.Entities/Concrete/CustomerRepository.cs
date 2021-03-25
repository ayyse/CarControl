using CarControl.Entities.Abstract;
using CarControl.Entities.DataAccess;
using CarControl.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarControl.Entities.Concrete
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        private readonly CarContext _context;
        public CustomerRepository(CarContext context) : base(context)
        {
            _context = context;
        }
    }
}
