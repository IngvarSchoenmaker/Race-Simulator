using Controller;
using System;
using System.Threading;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Data.Initialize();
            Console.WriteLine(Data.CurrentRace.Track.Name);
            for (; ; )
            {
                Thread.Sleep(100);
            }
        }
    }
}
