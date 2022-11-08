using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Ping
    {
        public delegate void Ud();
        public event Ud Vivod;
        public void Udar()
        {
            Console.WriteLine("Ping received Pong.");
            if (Vivod != null)
                Vivod();
        }
    }

}
