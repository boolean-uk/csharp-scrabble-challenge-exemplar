﻿using csharp_scrabble_challenge_exemplar.Main;
using NUnit.Framework;

namespace csharp_scrabble_challenge_exemplar.Test
{
    [TestFixture]
    public class ScrabbleTest
    {                             
        [Test]
        [TestCase("", 0)]
        [TestCase(" ", 0)]
        [TestCase(" \t\n", 0)]
        [TestCase("\n\r\t\b\f",0)]
        [TestCase("a", 1)]
        [TestCase("f", 4)]
        [TestCase("OXyPHEnBUTaZoNE", 41)]
        [TestCase("quirky", 22)]
        [TestCase("street", 6)]
        public void WordScoreTests(string word, int targetScore)
        {
            Assert.AreEqual(this.GetWordScore(word), targetScore);
        }

        private int GetWordScore(string word) => new Scrabble(word).score();
    }
}