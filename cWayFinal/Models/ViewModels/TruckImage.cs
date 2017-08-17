using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cWayFinal.Models.ViewModels
{
    public class TruckImage
    {
        public int TruckImageId { get; set; }
        public Truck Truck { get; set; }
        public Image Image { get; set; }
    }
}