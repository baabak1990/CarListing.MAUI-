using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarListingMAUI.APP.Models.Base;

namespace CarListingMAUI.APP.Models
{
    public class CarMart : BaseEntity
    {
        public List<Car> Cars { get; set; }
    }
}
