using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCountries.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }
        public string Flag { get; set; }
    }
}
