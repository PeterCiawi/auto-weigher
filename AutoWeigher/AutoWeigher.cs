using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;


namespace AutoWeigher
{
    namespace Lib
    {

        public class AutoWeigher
        {
            SerialPort port;
            public AutoWeigher(string portName)
            {
                port = new SerialPort(portName);
                port.Open();
            }
            public void Weight(double weight)
            {
                port.Write($"<{weight}>");
            }

            public event EventHandler<WeightDoneArgs> WeightDone;

            private void ReadLineFunction()
            {

                while (true)
                {
                    string n = port.ReadLine();
                    n.Trim();
                    if (n.Contains('<'))
                    {
                        n = n.Substring(1 ,n.Length - 3);                     
                        double weight = double.Parse(n);
                        WeightDoneArgs args = new WeightDoneArgs();
                        args.Weight = weight;
                        WeightDone?.Invoke(this, args);
                    }
                }
            }
            public void Begin()
            {
                Thread thread = new Thread(new ThreadStart(new Action(() => ReadLineFunction())));
                thread.Start();
            }
            public static string[] PortNames
            {
                get
                {
                    return SerialPort.GetPortNames();
                }
            }
        }
    }
}
