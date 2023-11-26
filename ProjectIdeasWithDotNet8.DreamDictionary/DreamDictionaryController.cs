using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectIdeasWithDotNet8.DreamDictionary.Services;

namespace ProjectIdeasWithDotNet8.DreamDictionary
{
    [Route("api/[controller]")]
    public class DreamDictionaryController : ControllerBase
    {
        private readonly DataService _dataService;

        public DreamDictionaryController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataService.GetHeaders());
        }

        [HttpGet("{id}")]
        public IActionResult GetQuestions(int id)
        {
            return Ok(_dataService.GetDetail().Where(x => x.BlogId == id).ToList());
        }
    }
}