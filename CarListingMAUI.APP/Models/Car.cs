using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarListingMAUI.APP.Models.Base;

namespace CarListingMAUI.APP.Models
{
    public class Car:BaseEntity
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Colors { get; set; }
        public string Vin { get; set; }
    }


  
}
