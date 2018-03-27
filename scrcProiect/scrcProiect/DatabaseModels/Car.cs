using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace scrcProiect.DatabaseModels
{
    [Table("Car")]
    public class Car
    {

        [Column("Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("LicensePlate")]
        public string LicensePlate { get; set; }

        [Required]
        [Column("Brand")]
        public string Brand { get; set; }

        [Required]
        [Column("Model")]
        public string Model { get; set; }

        [Column("Color")]
        public string Color { get; set; }

        [Column("Year")]
        public int Year { get; set; }
    }
}