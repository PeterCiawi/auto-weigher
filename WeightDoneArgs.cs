using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWeigher
{
    public class WeightDoneArgs: EventArgs
    {
       public double Weight { get; set; }
    }
}
