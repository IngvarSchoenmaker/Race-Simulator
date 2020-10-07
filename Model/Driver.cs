using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Driver : IParticipant
    {
        public IEquipment Equipment { get; set; }

        public string Name { get; set; }

        public int Points { get; set; }

        public TeamColors TeamColor { get; set; }
        public Driver(IEquipment equipment, string name, int points, TeamColors teamcolor)
        {
            Equipment = equipment;
            Name = name;
            Points = points;
            TeamColor = teamcolor;
        }
    }
}
