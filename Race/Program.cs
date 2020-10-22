using Controller;
using System;
using System.Threading;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.Initialize();
            Console.WriteLine(Data.CurrentRace.Track.Name);
            Visualisatie.DrawTrack(Data.CurrentRace.Track);
            for (; ; )
            {
                Thread.Sleep(100);
            }
        }
    }
}
