using System;
using System.Collections.Generic;
using SahinTurizim.Data.Abstract;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Concrete.EfCore
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City, SahinTurizimContext>, ICityRepository
    {
        
    }
}
