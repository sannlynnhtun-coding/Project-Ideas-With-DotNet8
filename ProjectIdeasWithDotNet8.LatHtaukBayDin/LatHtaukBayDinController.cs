using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MinTheinKha.LatHtaukBayDin.Services;

namespace ProjectIdeasWithDotNet8.LatHtaukBayDin
{
    [Route("api/[controller]")]
    public class LatHtaukBayDinController : ControllerBase
    {
        private readonly DataService _dataService;

        public LatHtaukBayDinController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet, Route("GetNumberList")]
        public IActionResult GetNumberList()
        {
            return Ok(_dataService.GetNumberList());
        }

        [HttpGet, Route("GetQuestions")]
        public IActionResult GetQuestions()
        {
            return Ok(_dataService.GetQuestions());
        }

        [HttpGet, Route("GetAnswer/{questionId}/{answerId}")]
        public IActionResult GetAnswer(int questionId, int answerId)
        {
            return Ok(_dataService.GetAnswers().FirstOrDefault(x=> x.QuestionNo == questionId && x.AnswerNo == answerId));
        }
    }
}