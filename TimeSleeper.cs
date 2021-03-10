using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class TimeSleeper
    {
        public static void TimeSleep(int second)
        {
            int ms = second * 100;

            System.Threading.Thread.Sleep(ms);
        }
    }
}
