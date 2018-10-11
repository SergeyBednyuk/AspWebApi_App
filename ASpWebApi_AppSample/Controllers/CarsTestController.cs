using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASpWebApi_AppSample.Models;

namespace ASpWebApi_AppSample.Controllers
{
    public class CarsTestController : ApiController
    {
        private CarsDbContext _db = new CarsDbContext();

        [HttpGet]
        public IEnumerable<Car> AllCars()
        {
            return _db.Cars;
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
