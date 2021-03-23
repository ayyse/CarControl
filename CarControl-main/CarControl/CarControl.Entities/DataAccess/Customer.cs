using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarControl.Entities.DataAccess

{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [NotMapped]
        public List<Car> Cars { get; set; }

        public string FullName { get; set; }
    }
}
