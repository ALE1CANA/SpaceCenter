using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread houstonThread = new Thread(HoustonCountdown);
            Thread capeCanaveralThread = new Thread(CapeCanaveralCountdown);

            houstonThread.Start();
            capeCanaveralThread.Start();

            houstonThread.Join();
            capeCanaveralThread.Join();

            Console.WriteLine("Rampa di lancio: Si parte!!!");
            Console.ReadLine();
        }

        static void HoustonCountdown()
        {
            Countdown("Houston");
        }

        static void CapeCanaveralCountdown()
        {
            Countdown("Cape Canaveral");
        }

        static void Countdown(string stazione)
        {
            for (int i = 10; i > 0; i--)
            {
                Thread.Sleep(1000);
                Console.WriteLine(stazione + ": "+ i);
            }
            Thread.Sleep(1000);
            Console.WriteLine(stazione + ": Go!");
        }
    }

}
