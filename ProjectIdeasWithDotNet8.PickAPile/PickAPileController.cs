using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectIdeasWithDotNet8.PickAPile.Services;

namespace ProjectIdeasWithDotNet8.PickAPile
{
    [Route("api/[controller]")]
    public class PickAPileController : ControllerBase
    {
        private readonly DataService _dataService;

        public PickAPileController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet("{pageNo}/{pageSize}")]
        public IActionResult Get(int pageNo, int pageSize)
        {
            return Ok(_dataService.GetQuestions(pageNo, pageSize));
        }

        [HttpGet("{questionId}")]
        public IActionResult Get(int questionId)
        {
            return Ok(_dataService.GetAnswer(questionId));
        }
    }
}