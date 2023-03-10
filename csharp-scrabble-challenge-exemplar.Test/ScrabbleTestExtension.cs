using csharp_scrabble_challenge_exemplar.Main;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge_exemplar.Test
{
    [TestFixture]
    public class ScrabbleTestExtension
    {
        [Test]
        [TestCase("street", 6)] //TODO: change this to test triple word score
        public void WordScoreTests(string word, int targetScore)
        {
            Assert.AreEqual(this.GetWordScore(word), targetScore);
        }

        private int GetWordScore(string word) => new Scrabble(word).score();

    }
}
