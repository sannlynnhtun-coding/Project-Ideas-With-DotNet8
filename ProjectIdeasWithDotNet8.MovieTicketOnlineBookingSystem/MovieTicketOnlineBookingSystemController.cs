using Microsoft.AspNetCore.Mvc;
using ProjectIdeasWithDotNet8.MovieTicketOnlineBookingSystem.Services;
using System.Security.Policy;

namespace ProjectIdeasWithDotNet8.MovieTicketOnlineBookingSystem
{
    [Route("api/[controller]")]
    public class MovieTicketOnlineBookingSystemController : ControllerBase
    {
        private readonly DataService _dataService;

        public MovieTicketOnlineBookingSystemController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataService.Get());
        }

        #region Cinema

        [HttpGet, Route("GetCinemaList")]
        public IActionResult GetCinemaList()
        {
            return Ok(_dataService.GetCinemaList());
        }

        [HttpGet, Route("GetCinemaDetail/{CinemaId}")]
        public IActionResult GetCinemaDetail(int id)
        {
            var cinameDetail = _dataService.GetCinemaList().FirstOrDefault(x => x.CinemaId == id);
            return Ok(cinameDetail);
        }

        #endregion

        #region Movie

        [HttpGet, Route("GetMovieList")]
        public IActionResult GetMovieList()
        {
            return Ok(_dataService.GetMovieList());
        }

        [HttpGet, Route("GetMovieDetail/{MovieId}")]
        public IActionResult GetMovieDetail(int id)
        {
            var movieDetail = _dataService.GetMovieList().FirstOrDefault(x => x.MovieId == id);
            return Ok(movieDetail);
        }

        #endregion

        #region MovieDate and MovieSchedule

        [HttpGet, Route("GetMovieShowDate")]
        public IActionResult GetMovieShowDate()
        {
            return Ok(_dataService.GetMovieShowDate());
        }

        [HttpGet, Route("GetMovieShowDateDetail/{ShowDateId}")]
        public IActionResult GetMovieShowDateDetail(int id)
        {
            var movieShowDateDetail = _dataService.GetMovieShowDate().FirstOrDefault(x => x.ShowDateId == id);
            return Ok(movieShowDateDetail);
        }

        [HttpGet, Route("GetMovieSchedule")]
        public IActionResult GetMovieSchedule()
        {
            return Ok(_dataService.GetMovieSchedule());
        }

        [HttpGet, Route("GetMovieScheduleDetail/{ShowId}")]
        public IActionResult GetMovieScheduleDetail(int id)
        {
            var movieScheduleDetail = _dataService.GetMovieSchedule().FirstOrDefault(x => x.ShowId == id);
            return Ok(movieScheduleDetail);
        }

        #endregion

        #region CinemaRoom

        [HttpGet, Route("GetCinemaRoom")]
        public IActionResult GetCinemaRoom()
        {
            return Ok(_dataService.GetCinemaroom());
        }

        [HttpGet, Route("GetCinemaRoomDetail/{RoomId}")]
        public IActionResult GetCinemaRoomDetail(int id)
        {
            var cinemaRoomDetail = _dataService.GetCinemaroom().FirstOrDefault(x => x.RoomId == id);
            return Ok(cinemaRoomDetail);
        }

        #endregion

        #region RoomSeat

        [HttpGet, Route("GetRoomSeat")]
        public IActionResult GetRoomSeat()
        {
            return Ok(_dataService.GetRoomSeat());
        }

        [HttpGet, Route("GetRoomSeatDetail/{SeatId}")]
        public IActionResult GetRoomSeatDetail(int id)
        {
            var roomSeatDetail = _dataService.GetRoomSeat().FirstOrDefault(x => x.SeatId == id);
            return Ok(roomSeatDetail);
        }

        #endregion

        #region SeatPrice

        [HttpGet, Route("GetSeatPrice")]
        public IActionResult GetSeatPrice()
        {
            return Ok(_dataService.GetSeatPrice());
        }

        [HttpGet, Route("GetSeatPriceDetail/{SeatPriceId}")]
        public IActionResult GetSeatPriceDetail(int id)
        {
            var seatPriceDetail = _dataService.GetSeatPrice().FirstOrDefault(x => x.SeatPriceId == id);
            return Ok(seatPriceDetail);
        }

        #endregion

        [HttpGet, Route("GetBookDetail/{BookingId}")]
        public IActionResult GetBookingDetail()
        {
            var lst = _dataService.GetBookingDetail().Select(x => new
            {
                BookingId = x.BookingId,
                RoomId = x.RoomId,
                SeatId = x.SeatId,
                SeatNo = x.SeatNo,
                RowName = x.RowName,
                SeatType = x.SeatType,
                SeatPrice = x.SeatPrice,
                ShowDate = x.ShowDate
            }).ToList();
            return Ok(lst);
        }
    }
}
