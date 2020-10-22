using Model;
using System;

namespace Race
{
    public static class Visualisatie
    {
        #region graphics
        private static string[] _finishHorizontal = 
        { 
            "════",
            "░2░░",
            "░1░░",
            "════"
        };
        private static string[] _startHorizontal = 
        { 
            "════",
            "2)  ",
            "  1)",
            "════"
        };
        private static string[] _wegHorizontal = 
        { 
            "════",
            " 2  ",
            " 1  ",
            "════"
        };
        private static string[] _wegVerticaal = 
        { 
            "║  ║",
            "║2 ║", 
            "║ 1║", 
            "║  ║" 
        };
        private static string[] _linksBeneden = 
        { 
            "═══╗", 
            "  2║", 
            " 1 ║", 
            "╗  ║"
        };
        private static string[] _linksBoven = 
        { 
            "╝  ║", 
            "2  ║", 
            " 1 ║", 
            "═══╝" 
        };
        private static string[] _rechtsBeneden = 
        { 
            "╔═══", 
            "║ 2 ", 
            "║1  ", 
            "║  ╔" 
        };
        private static string[] _rechtsBoven = 
        { 
            "║  ╚", 
            "║2  ", 
            "║ 1 ", 
            "╚═══" 
        };

        #endregion
        public static int X = 20;
        public static int Y = 20;
        public static void Initialize()
        {

        }
        public static void DrawTrack(Track track)
        {
            Console.SetWindowSize(100, 70);
            int kijkrichting = 0;
            //https://www.geeksforgeeks.org/console-setcursorposition-method-in-c-sharp/
            foreach (var section in track.Sections)
            {
                if (section.sectionTypes == SectionTypes.StartGrid)
                {
                    Tekenen(_startHorizontal);
                    kijkrichting = 1;
                    X += 4;
                }
                if (section.sectionTypes == SectionTypes.RightCorner)
                {
                    switch (kijkrichting)
                    {
                        case 0:
                            Tekenen(_rechtsBeneden);
                            kijkrichting = 1;
                            X += 4;
                            break;
                        case 1:
                            Tekenen(_linksBeneden);
                            kijkrichting = 2;
                            Y += 4;
                            break;
                        case 2:
                            Tekenen(_linksBoven);
                            kijkrichting = 3;
                            X += -4;
                            break;
                        case 3:
                            Tekenen(_rechtsBoven);
                            kijkrichting = 0;
                            Y += -4;
                            break;
                    }
                }
                if (section.sectionTypes == SectionTypes.LeftCorner)
                {
                    switch (kijkrichting)
                    {
                        case 0:
                            Tekenen(_linksBeneden);
                            kijkrichting = 3;
                            X += -4;
                            break;
                        case 1:
                            Tekenen(_linksBoven);
                            kijkrichting = 0;
                            Y += -4;
                            break;
                        case 2:
                            Tekenen(_rechtsBoven);
                            kijkrichting = 1;
                            X += 4;
                            break;
                        case 3:
                            Tekenen(_rechtsBeneden);
                            kijkrichting = 2;
                            Y += 4;
                            break;
                    }
                }
                if (section.sectionTypes == SectionTypes.Straight)
                {
                    switch (kijkrichting)
                    {
                        case 0:
                            Tekenen(_wegVerticaal);
                            Y += -4;
                            break;
                        case 1:
                            Tekenen(_wegHorizontal);
                            X += 4;
                            break;
                        case 2:
                            Tekenen(_wegVerticaal);
                            Y += 4;
                            break;
                        case 3:
                            Tekenen(_wegHorizontal);
                            X += -4;
                            break;
                    }
                }
                if (section.sectionTypes == SectionTypes.Finish)
                {
                    if (kijkrichting == 1)
                    {
                        Tekenen(_finishHorizontal);
                        X += 4;
                        kijkrichting = 1;
                    }
                }
            }
        }
        public static void Tekenen(string[] stuck)
        {
            foreach (var lijn in stuck)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(lijn);
                Y += 1;
            }
            Y += -4;
        }
        public static void StartPositie()
        {

        }
    }
}
