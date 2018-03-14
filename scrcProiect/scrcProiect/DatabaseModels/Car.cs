using System;
using System.Collections.Generic;
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

        [Column("LicensePlate")]
        public string LicensePlate { get; set; }

        [Column("Brand")]
        public string Brand { get; set; }

        [Column("Model")]
        public string Model { get; set; }

        [Column("Color")]
        public string Color { get; set; }

        [Column("Year")]
        public int Year { get; set; }
    }
}