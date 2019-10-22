using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseManagement.Models
{
    public class House
    {
        public int ID { get; set; }
        public string HouseName { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
    }
}