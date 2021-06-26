using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;


namespace AutoWeigher
{
    public class AutoWeigher
    {
            SerialPort port;
        public AutoWeigher(string portName)
        {
            port = new SerialPort(portName);
            port.Open();
        }
        void Weight(double weight)
        {
            port.Write($"<{weight}>");
        }

        public event EventHandler<WeightDoneArgs> WeightDone;
        
        private void ReadLineFunction()
        {
            
            while (true)
            {
                string n = Console.ReadLine();
                n.Remove('<');
                n.Remove('>');
                double weight = Convert.ToDouble(n);
                WeightDoneArgs args = new WeightDoneArgs();
                args.Weight = weight;
                WeightDone?.Invoke(this, args);
            }
        }
        public void Begin()
        {
            Thread thread = new Thread(new ThreadStart(ReadLineFunction));
            thread.Start();
        } 
    }
}
