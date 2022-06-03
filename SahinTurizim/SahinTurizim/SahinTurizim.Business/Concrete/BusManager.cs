using System;
using System.Collections.Generic;
using SahinTurizim.Business.Abstract;
using SahinTurizim.Data.Abstract;
using SahinTurizim.Entity;

namespace SahinTurizim.Business.Concrete
{
    public class BusManager : IBusService
    {
    
        private IBusRepository _busRepository;
        public BusManager(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }
       

        public int BusSeatCapacity(int id)
        {
            return _busRepository.BusSeatCapacity(id);
        }
    }
}
