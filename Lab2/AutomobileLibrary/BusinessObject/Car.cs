using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.BusinessObject
{
    public class Car
    {
        public int carID { get; set; }
        public string carName { get; set; }
        public string manufacturer { get; set; }
        public double price { get; set; }
        public int releaseYear { get; set; }
    }
}
