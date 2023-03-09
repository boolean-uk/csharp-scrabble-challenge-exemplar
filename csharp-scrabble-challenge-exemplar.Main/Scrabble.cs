using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge_exemplar.Main
{
    public  class Scrabble
    {
        private string _word;
        private Dictionary<char, int> _letterScores;

        /// <summary>
        /// Class to score any word in Scrabble
        /// </summary>
        /// <param name="word">the word in which you wish to scrabble score</param>
        
        public Scrabble(string word)
        {
            _word = word;
            _letterScores = Alphabet.getLetterScores();


        }

        /// <summary>
        /// Returns the score of the word passed into the class constructor.
        /// </summary>
        /// <returns></returns>
        public int score()
        {
            int total = 0;
            
            if((_word.Contains('{'))&&(_word.Contains('}')))
            {
                return 0;
            }

            if(_word.Any(x => Char.IsWhiteSpace(x)))
            {
                return 0;
            }

            var ch = _word.ToCharArray();

            ch.ToList().ForEach(x =>
            {
                int score = _letterScores[Char.ToLowerInvariant(x)];
                total += score;
            });
            
            return total;
        }

    }
}
