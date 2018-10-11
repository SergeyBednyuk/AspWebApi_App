using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASpWebApi_AppSample.Models
{
    public class CarsDbInitialazer : DropCreateDatabaseIfModelChanges<CarsDbContext>
    {
        protected override void Seed(CarsDbContext context)
        {
            List<Car> list = new List<Car>()
            {
                new Car() {Name = "Honda", Model = "Accord", Price = 25000, Year = new DateTime(2017, 2, 14)},
                new Car() {Name = "Toyota", Model = "Camry", Price = 27000, Year = new DateTime(2018, 5, 23)},
                new Car() {Name = "Audi", Model = "A6", Price = 43000, Year = new DateTime(2016, 3, 11)},
                new Car() {Name = "Bmw", Model = "5 series", Price = 45000, Year = new DateTime(2017, 6, 01)},
                new Car() {Name = "Nissan", Model = "R32 GTR", Price = 100000, Year = new DateTime(1992, 1, 10)},
                new Car() {Name = "Honda", Model = "NSX", Price = 250000, Year = new DateTime(2017, 2, 14)},
                new Car() {Name = "Honda", Model = "NSX-R", Price = 150000, Year = new DateTime(1995, 6, 14)},
                new Car() { Name = "test", Model = "test", Price = 1000, Year = new DateTime(2000, 12,12)}
            };

            context.Cars.AddRange(list);
            context.SaveChanges();
        }
    }
}