using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge_exemplar.Main
{
    public static class Alphabet
    {
        public static Dictionary<char, int> getLetterScores()
        {
            Dictionary<char, int> results = new Dictionary<char, int>();
                        
            results.Add('a', 1);
            results.Add('b', 3);
            results.Add('c', 3);
            results.Add('d', 2);
            results.Add('e', 1);
            results.Add('f', 4);
            results.Add('g', 2);
            results.Add('h', 4);
            results.Add('i', 1);
            results.Add('j', 8);
            results.Add('k', 5);
            results.Add('l', 1);
            results.Add('m', 3);
            results.Add('n', 1);
            results.Add('o', 1);
            results.Add('p', 3);
            results.Add('q', 10);
            results.Add('r', 1);
            results.Add('s', 1);
            results.Add('t', 1);
            results.Add('u', 1);
            results.Add('v', 4);
            results.Add('w', 4);
            results.Add('x', 8);
            results.Add('y', 4);
            results.Add('z', 10);

            return results;

        }
    }
}
