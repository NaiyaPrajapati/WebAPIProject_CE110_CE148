using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiClient.Models
{
    public class Ticket
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string c_name { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string c_to { get; set; }
        [Required]
        public string c_from { get; set; }
        [Required]
        public DateTime dept_time { get; set; }
        [Required]
        public DateTime arrival_time { get; set; }
        [Required]
        public int total_seat { get; set; }
        [Required]
        public string seat_num { get; set; }
        [Required]
        public int amount { get; set; }
        [Required]
        public Boolean status { get; set; }


    }
}
