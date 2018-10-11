using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASpWebApi_AppSample.Models
{
    public class EngineInfo
    {
        public int EngineInfoId { get; set; }
        public string FuelType { get; set; }
        public int Displacement { get; set; }
        public int Power { get; set; }
    }
}