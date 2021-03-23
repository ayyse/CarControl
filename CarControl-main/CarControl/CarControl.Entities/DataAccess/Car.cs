using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarControl.Entities.DataAccess
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }


        [NotMapped]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        //[NotMapped]
        //public List<Time> Times { get; set; }


        public string Plaka { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime ExitTime { get; set; }
    }
}
