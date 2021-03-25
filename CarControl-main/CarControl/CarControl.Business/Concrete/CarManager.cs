using CarControl.Business.Abstract;
using CarControl.Entities.Abstract;
using CarControl.Entities.DataAccess;
using CarControl.Entities.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CarControl.Business.Concrete
{
    public class CarManager : IBaseRepository<Car>
    {
        private readonly IUnitofWork _unitofWork;
        public CarManager(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public Car Remove(Car entity)
        {
            var data = _unitofWork.carRepository.Remove(entity);
            _unitofWork.Save();
            return data;
        }

        public Car Get(int id)
        {
            return _unitofWork.carRepository.Get(id);
        }

        public List<Car> GetAll()
        {
            return _unitofWork.carRepository.GetAll().ToList();
        }

        public Car Add(Car entity)
        {
            var data = _unitofWork.carRepository.Add(entity);
            _unitofWork.Save();
            return data;
        }

        public Car Update(Car entity)
        {
            var data = _unitofWork.carRepository.Update(entity);
            _unitofWork.Save();
            return data;
        }
    }
}
