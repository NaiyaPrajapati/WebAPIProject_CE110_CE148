using Microsoft.EntityFrameworkCore;
using RestApiBusManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiBusManagement.Data
{
    public class BusManagementAppContext : DbContext
    {
        public BusManagementAppContext(DbContextOptions<BusManagementAppContext> options)
            : base(options)
        {
        }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Ticket> Ticket { get; set; }

        public DbSet<Payment> Payment { get; set; }
    }
}
