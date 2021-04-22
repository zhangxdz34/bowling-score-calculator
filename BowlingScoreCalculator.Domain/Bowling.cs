
namespace BowlingScoreCalculator.Domain
{
    using System.Collections.Generic;
    using System.Linq;

    public class Bowling
    {
        private List<int> Pins = new List<int>();

        public void AddRoll(int n) => Pins.Add(n);

        public void AddRolls(List<int> scores)
        {
            foreach (int score in scores)
            {
                AddRoll(score);
            }
        }

        public int GetScore() => Pins.Scores().Take(10).Sum();
    }

}
