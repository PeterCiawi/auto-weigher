using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;


namespace AutoWeigher
{
    namespace Lib
    {

        public class AutoWeigher
        {
            public bool IsWeighing { get; set; }

            SerialPort port;
            public AutoWeigher(string portName)
            {
                port = new SerialPort(portName);                
                port.Open();
            }
            public void Weight(double weight)
            {
                IsWeighing = true;
                port.Write($"<{weight}>");
            }

            

            public event EventHandler<WeightDoneArgs> WeightDone;

            string pattern = @"<(?<One>\d+[,.]?\d+)>";
            //pattern of regex

            private void ReadLineFunction()
            {

                while (true)
                {
                    string n = port.ReadLine();
                    n = n.Trim();

                    Match matches = Regex.Match(n, pattern);
                    if (matches.Success)
                    {
                        double weight = double.Parse(matches.Groups["One"].Value);
                        WeightDoneArgs args = new WeightDoneArgs();
                        IsWeighing = false;
                        args.Weight = weight;
                        WeightDone?.Invoke(this, args);
                    }
                    //One = Group of Regex = 00.00(in number)
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
