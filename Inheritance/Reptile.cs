using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool Aquatic { get; set; }
        public int Height { get; set; }
        public string AmountOfScales { get; set; }
        public string Diet { get; set; }

    }
}
