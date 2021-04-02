using Microsoft.AspNetCore.Mvc;
using RestApiBusManagement.Data;
using RestApiBusManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiBusManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
       
        private readonly ITicketRepo repo;
        public TicketController(ITicketRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Ticket>> getAllTickets()
        {
            var temp = repo.getAllTickets();
            return Ok(temp);

        }

        [HttpGet("{id}")]
        public ActionResult<Ticket> getTicket(int id)
        {
            var temp = repo.getTicket(id);
            return Ok(temp);

        }

        [HttpPost]
        public ActionResult addTicket(Ticket t)
        {
            Ticket tc = new Ticket();
            tc.id = t.id;
            tc.c_name = t.c_name;
            tc.email = t.email;
            tc.c_to = t.c_to;
            tc.c_from = t.c_from;
            tc.dept_time = t.dept_time;
            tc.arrival_time = t.arrival_time;
            tc.total_seat = t.total_seat;
            tc.seat_num = t.seat_num;
            tc.amount = t.amount;
            tc.status = t.status;
            repo.addTicket(tc);
            return Ok();
        }
        [HttpDelete("{id}")]

        public ActionResult deleteTicket(int id)
        {
            var temp = repo.deleteTicket(id);
            if (temp == false)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }


        }

        [HttpPut("{id}")]
        public ActionResult updateTicket(int id, Ticket t)
        {
            Ticket tc = repo.getTicket(id);
            tc.id = t.id;
            tc.c_name = t.c_name;
            tc.email = t.email;
            tc.c_to = t.c_to;
            tc.c_from = t.c_from;
            tc.dept_time = t.dept_time;
            tc.arrival_time = t.arrival_time;
            tc.total_seat = t.total_seat;
            tc.seat_num = t.seat_num;
            tc.amount = t.amount;
            tc.status = t.status;
            repo.updateTicket(tc);

            return Ok();
        }

    }
}
