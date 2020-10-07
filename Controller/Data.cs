using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Controller
{
    public static class Data
    {
        public static Competition Competition { get; set; }
        public static Race CurrentRace { get; set; }
        public static void Initialize()
        {
            Competition = new Competition();
            AddParticipants();
            AddTrack();
            NextRace();
        }
        public static void AddParticipants()
        {
            Car car = new Car(1, 1, 1, false);
            var d1 = new Driver(car, "Ingvar", 0, TeamColors.Blue);
            var d2 = new Driver(car, "Gertjan", 0, TeamColors.Blue);
            var d3 = new Driver(car, "KoningJunlian", 0, TeamColors.Blue);

            Competition.Participants.Add(d1);
            Competition.Participants.Add(d2);
            Competition.Participants.Add(d3);
        }
        public static void AddTrack()
        {
            var t1 = new Track("Rainbowroad1", new SectionTypes[] { SectionTypes.StartGrid, SectionTypes.Finish });
            var t2 = new Track("Rainbowroad2", new SectionTypes[] { SectionTypes.StartGrid, SectionTypes.Finish });
            var t3 = new Track("Rainbowroad3", new SectionTypes[] { SectionTypes.StartGrid, SectionTypes.Finish });

            Competition.Tracks.Enqueue(t1);
            Competition.Tracks.Enqueue(t2);
            Competition.Tracks.Enqueue(t3);
        }

        public static void NextRace()
        {
            CurrentRace = new Race(Competition.NextTrack(), Competition.Participants);
        }
    }
}
