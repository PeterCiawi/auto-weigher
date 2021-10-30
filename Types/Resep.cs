using System;

namespace Types
{
    public class Resep 
    {
        public string Nama { get; set; }
        public double Berat { get; set; }     
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
