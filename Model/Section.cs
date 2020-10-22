using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public enum SectionTypes
    {
        Straight,
        LeftCorner,
        RightCorner,
        StartGrid,
        Finish
    }
    public class Section
    {
        public SectionTypes sectionTypes { get; set; }

        public Section(SectionTypes sec)
        {
            sectionTypes = sec;
        }
    }
}
