using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceTwo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivityRecommendController : ControllerBase
    {
        private static readonly string[] Activity = new[]
        {
            "Walk", "StandStill", "Run", "Jog", "Sleep", "Play", "Netflix", "Drink", "Eat", "Drive"
        };

        private readonly ILogger<ActivityRecommendController> _logger;

        public ActivityRecommendController(ILogger<ActivityRecommendController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Activities> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Activities
            {
                Summary = Activity[rng.Next(Activity.Length)]
            })
            .ToArray();
        }
    }
}
