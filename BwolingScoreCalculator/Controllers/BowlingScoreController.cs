using BowlingScoreCalculator.Api.Models;
using BowlingScoreCalculator.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BwolingScoreCalculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BowlingScoreController : ControllerBase
    {
        private readonly ILogger<BowlingScoreController> _logger;

        public BowlingScoreController(ILogger<BowlingScoreController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("Calculate")]
        public BowlingScoreCalculationViewModel CalculateBowlingScoreResult([FromBody] BowlingScoreCalculationRequestBindingModel request)
        {
            Bowling bowling = new Bowling();

            bowling.AddRolls(request.Scores);

            BowlingScoreCalculationViewModel result = new BowlingScoreCalculationViewModel()
            {
                FrameCompleted = bowling.FrameCompleted(),
                Score = bowling.GetScore()
            };

            return result;
        }
    }
}
