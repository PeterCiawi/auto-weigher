using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWeigher
{
    namespace Lib
    {
       public class WeightDoneArgs: EventArgs
       {
          public double Weight { get; set; }
       }
    }
}
