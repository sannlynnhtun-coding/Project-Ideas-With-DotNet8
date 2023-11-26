using Microsoft.AspNetCore.Mvc;
using ProjectIdeasWithDotNet8.MyanmarMonths.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.MyanmarMonths
{
    [Route("api/[controller]")]
    public class MyanmarMonthsController : ControllerBase
    {
        private readonly DataService _dataService;

        public MyanmarMonthsController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataService.GetMonths().Select(x=>new
            {
                Id = x.Id,
                MonthEn = x.MonthEn,
                MonthMm = x.MonthMm,
                ImgUrl = x.ImgUrl
            }).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetQuestions(int id)
        {
            return Ok(_dataService.GetMonth(id));
        }
    }
}
