using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Pong
    {
        public delegate void Ud();
        public event Ud Vivod;
        public void Udar()
        {
            Console.WriteLine("Pong received Ping.");
            if (Vivod != null)
                Vivod();
        }
    }
}
