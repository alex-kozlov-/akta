using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public DateTime AddedDate{ get; set; }
        public DateTime RemovedDate { get; set; }
        public Decimal Cost { get; set; }
        public DateTime BoughtDate { get; set; }
        public bool IsAvailable { get; set; }
    }
}
