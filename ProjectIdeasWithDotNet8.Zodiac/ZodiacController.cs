using Microsoft.AspNetCore.Mvc;
using ProjectIdeasWithDotNet8.Zodiac.Services;

namespace ProjectIdeasWithDotNet8.Zodiac;

[Route("api/[controller]")]
public class ZodiacController : ControllerBase
{
    private readonly DataService _dataService;

    public ZodiacController(DataService dataService)
    {
        _dataService = dataService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_dataService.GetZodiac());
    }

    [HttpGet("{id}")]
    public IActionResult GetQuestions(int id)
    {
        return Ok(_dataService.GetZodiac(id));
    }
}