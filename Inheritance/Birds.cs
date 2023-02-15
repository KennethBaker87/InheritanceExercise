using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Birds : Animal
    {
        public double BeakLength { get; set; }
        public bool Feathers { get; set; }
        public double WingSpan { get; set; }
        public int FlightLength { get; set; }

    }
}
