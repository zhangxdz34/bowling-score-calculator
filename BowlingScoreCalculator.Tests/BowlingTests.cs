using BowlingScoreCalculator.Domain;
using NUnit.Framework;
using System.Linq;

namespace BowlingScoreCalculator.ServiceTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Bowling_Score_300_Expected()
        {
            Bowling bowling = new Bowling();

            int[] rolls = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

            bowling.AddRolls(rolls.ToList());

            int score = bowling.GetScore();

            Assert.AreEqual(300, score);
        }

        [Test]
        public void Test_Bowling_Score_20_Expected()
        {
            Bowling bowling = new Bowling();

            int[] rolls = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            bowling.AddRolls(rolls.ToList());

            int score = bowling.GetScore();

            Assert.AreEqual(20, score);

        }

        [Test]
        public void Test_Bowling_Score_60_Expected()
        {
            Bowling bowling = new Bowling();

            int[] rolls = new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };

            bowling.AddRolls(rolls.ToList());

            int score = bowling.GetScore();

            Assert.AreEqual(60, score);

        }

        /// <summary>
        /// sampe from:https://www.liveabout.com/bowling-scoring-420895
        /// </summary>
        [Test]
        public void Test_Bowling_Score_168_Expected()
        {
            Bowling bowling = new Bowling();

            int[] rolls = new int[] { 10, 7, 3, 7, 2, 9, 1, 10, 10, 10, 2, 3, 6, 4, 7, 3, 3 };

            bowling.AddRolls(rolls.ToList());

            int score = bowling.GetScore();

            Assert.AreEqual(168, score);

        }
    }
}