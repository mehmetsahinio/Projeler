using System;
using System.Collections.Generic;

namespace SahinTurizim.Data.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);
    }
}
