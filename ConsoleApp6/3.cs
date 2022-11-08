using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Gamer
    {
        private static void Main(string[] args)
        {
            Ping ping = new Ping();
            Pong pong = new Pong();
            Ping.Ud v = pong.Udar;
            Pong.Ud vi = ping.Udar;

            ping.Vivod += v;
            pong.Vivod += vi;
            ping.Udar();

        }
    }
}

