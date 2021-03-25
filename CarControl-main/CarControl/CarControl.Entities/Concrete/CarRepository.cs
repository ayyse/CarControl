using CarControl.Entities.Abstract;
using CarControl.Entities.DataAccess;
using CarControl.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarControl.Entities.Concrete
{
    public class CarRepository : RepositoryBase<Car>, ICarRepository
    {
        private readonly CarContext _context;
        public CarRepository(CarContext context) : base(context)
        {
            _context = context;
        }
    }
}
