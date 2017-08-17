using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cWayFinal.Models
{
    public class Truck
    {
        public int TruckId { get; set; }
        public string TruckVin { get; set; }
        public DateTime TruckDateAdded { get; set; }
        public int TruckCost { get; set; }
        public int TruckPrice { get; set; }
        public string TruckDescription { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}