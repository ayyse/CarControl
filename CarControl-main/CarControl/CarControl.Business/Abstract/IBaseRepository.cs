using System;
using System.Collections.Generic;
using System.Text;

namespace CarControl.Business.Abstract
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        T Add(T entity);
        T Update(T entity);
        T Remove(T entity);
    }
}
