using System;
using System.Collections;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Parking
    {
        public int Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Name { get; set; }
        public ICollection<Bicycle> Bicycles { get; set; }
        public DateTime OpenedDate { get; set; }
    }
}