using System.Collections.Generic;

namespace ChordIdentifyerExercise
{
    public static class ChordLibrary
    {
        private static Dictionary<string, bool[,]> Chords = new Dictionary<string, bool[,]>()
        {
            ["Am"] =
            new bool[,]{
                { true, false, false, false},
                { false, true, false, false},
                { false, false, true, false},
                { false, false, true, false},
                { true, false, false, false},
                { false, false, false, false},
            },
            ["Em"] =
            new bool[,]{
                { false, false, false, false},
                { false, false, false, false},
                { false, false, false, false},
                { false, false, false, false},
                { false, false, false, false},
                { false, false, false, false},
            },
            ["G"] =
            new bool[,]{
                { false, false, false, false},
                { false, false, false, false},
                { false, false, false, false},
                { false, false, false, false},
                { false, false, false, false},
                { false, false, false, false},
            }
        };

        public static Dictionary<string, bool[,]> GetChordLibrary()
        {
            return Chords;
        }
    }
}
