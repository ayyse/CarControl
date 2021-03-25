using System;
using System.Collections.Generic;
using System.Text;

namespace CarControl.Entities.Abstract
{
    public interface IUnitofWork : IDisposable
    {
        ICarRepository carRepository { get; }
        ICustomerRepository customerRepository { get; }
        void Save();
    }
}
