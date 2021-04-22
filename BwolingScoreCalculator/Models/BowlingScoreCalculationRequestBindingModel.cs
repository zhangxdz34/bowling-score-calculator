using System.Collections.Generic;

namespace BowlingScoreCalculator.Api.Models
{
    public class BowlingScoreCalculationRequestBindingModel
    {
        public List<int> Scores { get; set; }
    }
}
