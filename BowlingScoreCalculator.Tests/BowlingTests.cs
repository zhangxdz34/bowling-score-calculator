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

        [Test]
        public void Test_Bowling_Score_168_Expected()
        {
            Bowling bowling = new Bowling();

            int[] rolls = new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };

            bowling.AddRolls(rolls.ToList());

            int score = bowling.GetScore();

            Assert.AreEqual(60, score);

        }
    }
}