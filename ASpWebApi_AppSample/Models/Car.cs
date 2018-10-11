using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASpWebApi_AppSample.Models
{
    [Table("Car")]
    public class Car
    {
        //[ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Brand")]
        public string Name { get; set; }
        public string Model { get; set; }
        //[DataType(DataType.Date)]
        public DateTime Year { get; set; }
        //[Range(1.00, 10000000.00, ErrorMessage = "Price must be between 1$ and 10000000$")]
        public decimal Price { get; set; }
    }
}