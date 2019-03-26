using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CounterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            string print;

            Console.WriteLine("Welcome to Andrew Gray (102112347)'s clock!");
            Console.WriteLine("----------------INSTRUCTIONS---------------");
            Console.WriteLine("--  Press 'R' to Reset");
            Console.WriteLine("--  Press 'I' twice to add an Hour");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            while (true) //infinite loop.
            {
                print = clock.PrintTime();
                Console.Write("\r{0}",print);
                clock.Tick();
                System.Threading.Thread.Sleep(1000);

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.R)
                {
                    clock.ResetClock();
                }
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.I)
                {
                    clock.AddHour();
                }
            }
        }
    }
}
