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
            var d3 = new Driver(car, "koning Julien", 0, TeamColors.Blue);

            Competition.Participants.Add(d1);
            Competition.Participants.Add(d2);
            Competition.Participants.Add(d3);
        }
        public static void AddTrack()
        {
            Track oostendorp = new Track("Oostendorp",
                   new SectionTypes[] { SectionTypes.StartGrid, SectionTypes.StartGrid, SectionTypes.StartGrid,SectionTypes.Finish, SectionTypes.Straight,
                SectionTypes.LeftCorner, SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.RightCorner,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.RightCorner,SectionTypes.Straight, SectionTypes.RightCorner,
                SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,
                SectionTypes.LeftCorner,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight, SectionTypes.LeftCorner,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight, SectionTypes.RightCorner,
                SectionTypes.RightCorner, SectionTypes.LeftCorner, SectionTypes.LeftCorner, SectionTypes.RightCorner, SectionTypes.RightCorner,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,
                SectionTypes.RightCorner,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight,SectionTypes.Straight, SectionTypes.RightCorner,SectionTypes.Straight, SectionTypes.Straight, SectionTypes.Straight, SectionTypes.Straight});
            var t1 = new Track("Rainbowroad1", new SectionTypes[] { SectionTypes.StartGrid, SectionTypes.RightCorner, SectionTypes.RightCorner, SectionTypes.Straight, SectionTypes.Straight, SectionTypes.RightCorner, SectionTypes.RightCorner, SectionTypes.Finish });
            var t2 = new Track("Rainbowroad2", new SectionTypes[] { SectionTypes.StartGrid, SectionTypes.Finish });
            var t3 = new Track("Rainbowroad3", new SectionTypes[] { SectionTypes.StartGrid, SectionTypes.Finish });

            Competition.Tracks.Enqueue(oostendorp);
            Competition.Tracks.Enqueue(t2);
            Competition.Tracks.Enqueue(t3);
        }

        public static void NextRace()
        {
            CurrentRace = new Race(Competition.NextTrack(), Competition.Participants);
        }
    }
}
