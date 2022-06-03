using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.Business.Abstract
{
    public interface ICityService
    {

        City GetById(int id);
        void Create(City entity);
        void Update(City entity);
        void Delete(City entity);
        List<City> GetAll();
    }
}