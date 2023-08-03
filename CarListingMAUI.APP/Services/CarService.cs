using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarListingMAUI.APP.Models;

namespace CarListingMAUI.APP.Services
{
    public class CarService
    {
        public List<Car> GetAllCars()
        {
            return new List<Car>()
            {
                new Car()
                {
                    Id = 1, CreateDate = DateTime.Now, Mark = "Opel", Colors = "Yellow", Model = "Z1", Vin = "213342"
                },
                new Car()
                {
                    Id = 2, CreateDate = DateTime.Now, Mark = "Porsche", Colors = "black", Model = "Cayne", Vin = "223342"
                },
                new Car()
                {
                    Id = 3, CreateDate = DateTime.Now, Mark = "BMW", Colors = "White", Model = "X7", Vin = "98945"
                },
                new Car()
                {
                    Id = 4, CreateDate = DateTime.Now, Mark = "Benz", Colors = "Orange", Model = "G4", Vin = "8486465"
                },
            };
        }
    }
}
