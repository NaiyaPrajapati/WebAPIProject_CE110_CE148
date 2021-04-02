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
    public class BusController : ControllerBase
    {

        private readonly IBusRepo repo;
        public BusController(IBusRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Bus>> getAllBuses()
        {
            var temp = repo.getAllBuses();
            return Ok(temp);

        }

        [HttpGet("{id}")]
        public ActionResult<Bus> getBus(int id)
        {
            var temp = repo.getBus(id);
            return Ok(temp);

        }

        [HttpPost]
        public ActionResult addBus(Bus b)
        {
            Bus bs = new Bus();
            bs.id = b.id;
            bs.source = b.source;
            bs.destination = b.destination;
            bs.arrival_time = b.arrival_time;
            bs.dept_time = b.dept_time;
            bs.bus_no = b.bus_no;
            bs.price = b.price;
            repo.addBus(bs);
            return Ok();
        }
        [HttpDelete("{id}")]

        public ActionResult deleteBus(int id)
        {
            var temp = repo.deleteBus(id);
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
        public ActionResult updateBus(int id, Bus b)
        {
            Bus bs = repo.getBus(id);
            bs.id = b.id;
            bs.source = b.source;
            bs.destination = b.destination;
            bs.arrival_time = b.arrival_time;
            bs.dept_time = b.dept_time;
            bs.bus_no = b.bus_no;
            bs.price = b.price;
            repo.updateBus(bs);

            return Ok();
        }

    }
}
