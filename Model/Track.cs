using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Track
    {
        public string Name { get; set; }
        public LinkedList<Section> Sections { get; set; }

        public Track(string name, SectionTypes[] sections)
        {
            Name = name;
            Sections = new LinkedList<Section>();
            Sections = Convert(sections);
        }
        
        public LinkedList<Section> Convert(SectionTypes[] section)
        {
            LinkedList<Section> list = new LinkedList<Section>();
            foreach (var item in section)
            {
                Section newSection = new Section(item);
                list.AddLast(newSection);
            }
            return list;
        }
    }
}
