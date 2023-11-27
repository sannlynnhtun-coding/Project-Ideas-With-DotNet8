using Microsoft.AspNetCore.Mvc;
using ProjectIdeasWithDotNet8.MyanmarProverbs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.MyanmarProverbs
{
    [Route("api/[controller]")]
    public class MyanmarProverbsController:ControllerBase
    {
        private readonly DataService _dataService;

        public MyanmarProverbsController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult GetMMProverbsTitle()
        {
            var result = _dataService.MMProverbsTitle;
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetMMProverbDetail(int id)
        {
            var result = _dataService.MMProverbDetail.FirstOrDefault(x => x.TitleId == id);
            return Ok(result);
        }
    }
}
