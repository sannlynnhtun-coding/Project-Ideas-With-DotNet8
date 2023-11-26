using Microsoft.AspNetCore.Mvc;
using ProjectIdeasWithDotNet8.Birds.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.Birds
{

    [Route("api/[controller]")]
    public class BirdsController : ControllerBase
    {
        private readonly DataService _dataService;

        public BirdsController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataService.GetBirds());
        }

        [HttpGet("{id}")]
        public IActionResult GetQuestions(int id)
        {
            return Ok(_dataService.GetBird(id));
        }
    }
}
