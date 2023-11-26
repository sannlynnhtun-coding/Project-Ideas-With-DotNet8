using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectIdeasWithDotNet8.BaganMap.Models;
using ProjectIdeasWithDotNet8.BaganMap.Services;

namespace ProjectIdeasWithDotNet8.LatHtaukBayDin
{
    [Route("api/[controller]")]
    public class BaganMapController : ControllerBase
    {
        private readonly DataService _dataService;

        public BaganMapController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet, Route("GetRouteId")]
        public IActionResult GetRouteId()
        {
            var lst = _dataService.TravelRouteList().Select(x => new
            {
                TravleRoutId = x.TravelRouteId,
                TravelRouteName = x.TravelRouteName
            }).ToList();   
            return Ok(lst);
        }

        [HttpGet,Route("GetRoute/{travelRouteId}")]
        public IActionResult GetRoute(string travelRouteId)
        {
            var baganMapInfo = _dataService.TravelRouteList()
                .FirstOrDefault(x => x.TravelRouteId == travelRouteId);
            return Ok(baganMapInfo);
        }

        [HttpGet,Route("MapInfoDetail/{Id}")]
        public IActionResult GetMapInfoDetail(string Id)
        {
            var mapInfoDetail = _dataService.BaganMapInfoDetail.FirstOrDefault(x => x.Id == Id);
            return Ok(mapInfoDetail);
        }
    }
}