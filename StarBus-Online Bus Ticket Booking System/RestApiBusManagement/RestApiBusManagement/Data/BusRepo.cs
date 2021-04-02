using RestApiBusManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiBusManagement.Data
{
    public class BusRepo : IBusRepo
    {
        private readonly BusManagementAppContext context;

        public BusRepo(BusManagementAppContext context)
        {
            this.context = context;
        }
        public void addBus(Bus b)
        {
            context.Bus.Add(b);
            context.SaveChanges();
            return;
            //throw new NotImplementedException();
        }

        public bool deleteBus(int id)
        {
            var deleteItm = context.Bus.Find(id);
            if (deleteItm == null)
            {
                return false;
            }
            else
            {
                context.Bus.Remove(deleteItm);
                context.SaveChanges();
                return true;
            }

            // throw new NotImplementedException();
        }


       

        public IEnumerable<Bus> getAllBuses()
        {
            return context.Bus;
            //throw new NotImplementedException();
        }

            

        public Bus getBus(int id)
        {
            var prod = context.Bus.Find(id);
            if (prod == null)
            {
                return null;
            }
            else
            {
                return prod;
            }
            //throw new NotImplementedException();
        }

        public void updateBus(Bus b)
        {
            var t = context.Bus.Attach(b);
            t.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return;
            //throw new NotImplementedException();
        }
    }
}
