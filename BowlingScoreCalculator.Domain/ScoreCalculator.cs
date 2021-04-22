
namespace BowlingScoreCalculator.Domain
{
    using System.Collections.Generic;

    public static class PinsExtensions
    {
        public static IEnumerable<int> Scores(this IList<int> pins)
        {
            // Walk the list in steps of two rolls (= one frame)
            for (int i = 0; i + 1 < pins.Count; i += 2)
            {
                // Neither strike nor spare
                if (pins[i] + pins[i + 1] < 10)
                {
                    yield return pins[i] + pins[i + 1];
                    continue;
                }

                // Score can only be determined if third roll is available
                if (i + 2 >= pins.Count)
                {
                    yield break;
                }

                yield return pins[i] + pins[i + 1] + pins[i + 2];

                // In case of strike, advance only by one
                if (pins[i] == 10)
                {
                    i--;
                }
            }
        }

    }
}
