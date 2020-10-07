using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Race
    {
        public Track Track { get; set; }
        public DateTime StartTime { get; set; }
        public List<IParticipant> Participants { get; set; }

        private Random _random;
        private Dictionary<Section, SectionData> _positions;

        public Race(Track track, List<IParticipant> participants)
        {
            Track = track;
            Participants = participants;
            _random = new Random(DateTime.Now.Millisecond);
            StartTime = new DateTime();
            _positions = new Dictionary<Section, SectionData>();
        }

        public SectionData GetSectionData(Section section)
        {
            if (_positions.TryGetValue(section, out SectionData value))
            {
                return value;
            }
            else
            {
                _positions.Add(section, new SectionData());
            }
            
            return _positions[section];
        }
        public void RandomizeEquipment()
        {
            foreach (var par in Participants)
            {
                par.Equipment.Quality = int.Parse(_random.ToString());
                par.Equipment.Performance = int.Parse(_random.ToString());
            }
        }
    }
}
