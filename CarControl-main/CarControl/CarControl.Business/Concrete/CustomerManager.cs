using CarControl.Business.Abstract;
using CarControl.Entities.Abstract;
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
        private readonly IUnitofWork _unitofWork;
        public CustomerManager(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }
        public Customer Remove(Customer entity)
        {
            var data = _unitofWork.customerRepository.Remove(entity);
            _unitofWork.Save();
            return data;
        }

        public Customer Get(int id)
        {
            return _unitofWork.customerRepository.Get(id);
        }

        public List<Customer> GetAll()
        {
            return _unitofWork.customerRepository.GetAll().ToList();
        }

        public Customer Add(Customer entity)
        {
            var data = _unitofWork.customerRepository.Add(entity);
            _unitofWork.Save();
            return data;
        }

        public Customer Update(Customer entity)
        {
            var data = _unitofWork.customerRepository.Update(entity);
            _unitofWork.Save();
            return data;
        }
    }
}
