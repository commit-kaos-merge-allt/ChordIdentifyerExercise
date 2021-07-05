using System;

namespace ChordIdentifyerExercise
{
    public class ChordService
    {
        public bool[,] GetChord(string choardQuery)
        {
            foreach (var kvp in ChordLibrary.GetChordLibrary())
            {
                string chordName = kvp.Key;
                bool[,] chord = kvp.Value;

                // Är chordName == chordQuery
                // om det är samma, returna ackordet
            }
            return null;
        }

        public string GetChord(bool[,] chordInput)
        {
            foreach (var kvp in ChordLibrary.GetChordLibrary())
            {
                string chordName = kvp.Key;
                bool[,] chord = kvp.Value;

                // Är chordInput == chord
                // om det är samma, returna namnet på ackordet
            }
            return null;
        }
    }
}
