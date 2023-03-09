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
        public void Extension_shouldScore10forZasTriple()
        {

            Scrabble scrabble = new Scrabble("{z}");
            Assert.AreEqual(10, scrabble.score());
        }

    }
}
