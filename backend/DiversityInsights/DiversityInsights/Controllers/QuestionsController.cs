using DiversityInsights.Models;
using DiversityInsights.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace DiversityInsights.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController : ControllerBase
    {

        private readonly ILogger<QuestionsController> _logger;

        // replace with db
        private static readonly IList<Question> _questionList = new List<Question>()
        {
            new Question
            {
                Id = 0,
                QuestionText = "Who would you rather have dinner with?",
                Score = QuestionScore.Positive
            },
            new Question
            {
                Id = 1,
                QuestionText = "Who would you rather go on a date with?",
                Score = QuestionScore.Positive
            },
            new Question
            {
                Id = 2,
                QuestionText = "Who would you rather hang out with?",
                Score = QuestionScore.Positive
            },
            new Question
            {
                Id = 3,
                QuestionText = "Who is more likely to put the shopping cart back in the corral?",
                Score = QuestionScore.Positive
            },
            new Question
            {
                Id = 4,
                QuestionText = "Who is more likely to hold an elevator door open for you?",
                Score = QuestionScore.Positive
            },
            new Question
            {
                Id = 5,
                QuestionText = "Who is more likely to volunteer and/or contribute to charity?",
                Score = QuestionScore.Positive
            },
            new Question
            {
                Id = 6,
                QuestionText = "Who is more likely to commit a crime?",
                Score = QuestionScore.Negative
            },
            new Question
            {
                Id = 7,
                QuestionText = "Who is more to over-use recreational drugs?",
                Score = QuestionScore.Negative
            },
            new Question
            {
                Id = 8,
                QuestionText = "Who are you more likely to avoid while walking down street?",
                Score = QuestionScore.Negative
            },
            new Question
            {
                Id = 9,
                QuestionText = "Who is more likely to annoy you?",
                Score = QuestionScore.Negative
            },
            new Question
            {
                Id = 10,
                QuestionText = "Who is more likely to be unemployed?",
                Score = QuestionScore.Negative
            },
            new Question
            {
                Id = 11,
                QuestionText = "Who is more likely to overspend money?",
                Score = QuestionScore.Negative
            },
        };

        public QuestionsController(ILogger<QuestionsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "questions-list")]
        public IActionResult QuestionsList()
        {
            var questionsArr = _questionList.Select(x => new { Id = x.Id, Question = x.QuestionText.ToString(), Score = x.Score.ToString() });
            return Ok(questionsArr);
        }
    }
}
