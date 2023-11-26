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
            var routeIdList = new List<string>
            {
                "7C1DDEED-1B9E-4B54-8AE9-986BB44C42C1",
                "5381343D-1F64-4D39-849A-E889C554B5E6"
            };   
            return Ok(routeIdList);
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