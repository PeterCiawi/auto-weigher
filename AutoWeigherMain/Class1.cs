using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWeigherMain
{
    public class Resep
    {
        public string Nama { get; set; }
        public double Code { get; set; }
        public override string ToString()
        {
            return Nama;
        }

    }
}