using RestApiBusManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiBusManagement.Data
{
    public class TicketRepo : ITicketRepo
    {
        private readonly BusManagementAppContext context;

        public TicketRepo(BusManagementAppContext context)
        {
            this.context = context;
        }
        public void addTicket(Ticket t)
        {
            context.Ticket.Add(t);
            context.SaveChanges();
            return;
            //throw new NotImplementedException();
        }
        public void addPayment(Payment p)
        {
            context.Payment.Add(p);
            context.SaveChanges();
            return;
            //throw new NotImplementedException();
        }
        public bool deleteTicket(int id)
        {
            var deleteItm = context.Ticket.Find(id);
            if (deleteItm == null)
            {
                return false;
            }
            else
            {
                context.Ticket.Remove(deleteItm);
                context.SaveChanges();
                return true;
            }

            // throw new NotImplementedException();
        }




        public IEnumerable<Ticket> getAllTickets()
        {
            return context.Ticket;
            //throw new NotImplementedException();
        }

        

        public Ticket getTicket(int id)
        {
            var prod = context.Ticket.Find(id);
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

        public void updateTicket(Ticket t)
        {
            var temp = context.Ticket.Attach(t);
            temp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return;
            //throw new NotImplementedException();
        }

        
    }
}
