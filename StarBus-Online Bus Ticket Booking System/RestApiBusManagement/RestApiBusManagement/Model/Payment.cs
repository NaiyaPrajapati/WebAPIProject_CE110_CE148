using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiBusManagement.Model
{
    public class Payment
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string card_no{ get; set; }
        [Required]
        public DateTime date{ get; set; }
        
        [Required]
        public int cvv { get; set; }
        [Required]
        public int amount { get; set; }
    }
}
