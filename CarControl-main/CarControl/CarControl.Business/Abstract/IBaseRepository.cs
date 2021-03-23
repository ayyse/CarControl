using System;
using System.Collections.Generic;
using System.Text;

namespace CarControl.Business.Abstract
{
    public interface IBaseRepository<T>
    {
        List<T> GetList();
        T Get(int id);
        T Save(T entity);
        T Update(int id, T entity);
        T Delete(int id, T entity);
    }
}
