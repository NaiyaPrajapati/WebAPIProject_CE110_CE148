using RestApiBusManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiBusManagement.Data
{
    public interface ITicketRepo
    {
        public void addTicket(Ticket t);
        public bool deleteTicket(int id);
        public void updateTicket(Ticket t);
        public IEnumerable<Ticket> getAllTickets();
        public Ticket getTicket(int id);

        public void addPayment(Payment p);

    }
}
