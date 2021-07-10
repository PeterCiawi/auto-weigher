using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoWeigher;
using AutoWeigher.Lib;

namespace AutoWeigherTester
{
    class AutoWeigherDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avalible ports :");
            for (int i = 0; i < AutoWeigher.Lib.AutoWeigher.PortNames.Length; i++) 
            {
                Console.WriteLine(i + 1 + " " + AutoWeigher.Lib.AutoWeigher.PortNames[i]);
            }

            int n = int.Parse(Console.ReadLine());

            AutoWeigher.Lib.AutoWeigher autoWeigher = new AutoWeigher.Lib.AutoWeigher(AutoWeigher.Lib.AutoWeigher.PortNames[n - 1]);

            Console.Write("Enter weight : ");
            double weight = double.Parse(Console.ReadLine());

            autoWeigher.Weight(weight);

        }
        
    }
}
