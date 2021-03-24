using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarControl.Entities.DataAccess
{
    public class Car : BaseEntity
    {
        
        [NotMapped]
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }


        public string Plaka { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime ExitTime { get; set; }
    }
}
