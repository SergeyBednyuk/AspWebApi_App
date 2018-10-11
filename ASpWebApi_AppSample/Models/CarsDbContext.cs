using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASpWebApi_AppSample.Models
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext()
            :base("CarsDbConnectionString") {}

        public DbSet<Car> Cars { get; set; }
    }
}