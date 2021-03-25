using System;
using System.Collections.Generic;
using System.Text;

namespace CarControl.Entities.Abstract
{
    public interface IRepositoryBase<T> where T : class, new()
    {
        List<T> GetAll();
        T Get(int id);
        T Add(T entity);
        T Update(T entity);
        T Remove(T entity);
    }
}
