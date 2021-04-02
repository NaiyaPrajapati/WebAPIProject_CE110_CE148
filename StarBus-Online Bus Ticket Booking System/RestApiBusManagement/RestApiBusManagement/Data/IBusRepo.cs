using RestApiBusManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RestApiBusManagement.Data
{
    public interface IBusRepo
    {
        public void addBus(Bus b);
        public bool deleteBus(int id);
        public void updateBus(Bus b);
        public IEnumerable<Bus> getAllBuses();
        public Bus getBus(int id);

    }
}
