using DiversityInsights.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace DiversityInsights.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiversityPossibilitiesController : ControllerBase
    {

        private readonly ILogger<DiversityPossibilitiesController> _logger;

        // Should get these from a database
        private static readonly IEnumerable<Race> _raceList = Enum.GetValues(typeof(Race)).Cast<Race>().ToList();
        private static readonly IEnumerable<Gender> _genderList = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
        private static readonly IEnumerable<SexualOrientation> _sexualOrientationList = Enum.GetValues(typeof(SexualOrientation)).Cast<SexualOrientation>().ToList();
        private static readonly IEnumerable<Education> _educationList = Enum.GetValues(typeof(Education)).Cast<Education>().ToList();

        public DiversityPossibilitiesController(ILogger<DiversityPossibilitiesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "generate-minified")]
        public IActionResult GenerateMinified()
        {
            // Replace Id with guid or db id
            var possibilitiesArr = _raceList
                .SelectMany(raceList => _genderList, (race, gender) => new { Race = race.ToString(), Gender = gender.ToString() })
                .SelectMany(combined => _sexualOrientationList, (combined, sexualOrientation) => new { combined.Race, combined.Gender, SexualOrientation = sexualOrientation.ToString() })
                .SelectMany((combined) => _educationList, (combined, education) => new { combined.Race, combined.Gender, combined.SexualOrientation, Education = education.ToString() })
                .Select((item, id) => new
                {
                    Id = id,
                    item.Race,
                    item.Gender,
                    item.SexualOrientation,
                    item.Education
                })
                .ToArray();


            return Ok(possibilitiesArr);
        }
    }
}
