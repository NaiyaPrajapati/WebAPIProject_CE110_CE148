using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiClient.Models
{
    public class Bus
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string source { get; set; }
        [Required]
        public string destination { get; set; }
        [Required]
        public DateTime dept_time { get; set; }
        [Required]
        public DateTime arrival_time { get; set; }
        [Required]
        public int bus_no { get; set; }
        [Required]
        public int price { get; set; }

    }
}
