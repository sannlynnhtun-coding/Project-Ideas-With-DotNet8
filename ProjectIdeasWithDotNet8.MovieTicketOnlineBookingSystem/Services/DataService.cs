using Newtonsoft.Json;
using ProjectIdeasWithDotNet8.MovieTicketOnlineBookingSystem.Models;

namespace ProjectIdeasWithDotNet8.MovieTicketOnlineBookingSystem.Services
{
    public class DataService
    {
        private readonly string _jsonString;

        public DataService(string jsonString)
        {
            _jsonString = jsonString;
        }

        public MovieResponseModel Get()
        {
            return JsonConvert.DeserializeObject<MovieResponseModel>(_jsonString);
        }

        public List<Tbl_Movielist> GetMovieList()
        {
            return Get().Tbl_MovieList.ToList();
        }

        public List<Tbl_Cinemalist> GetCinemaList()
        {
            return Get().Tbl_CinemaList.ToList();
        }

        public List<Tbl_Movieshowdate> GetMovieShowDate()
        {
            return Get().Tbl_MovieShowDate.ToList();
        }

        public List<Tbl_Movieschedule> GetMovieSchedule()
        {
            return Get().Tbl_MovieSchedule.ToList();
        }

        public List<Tbl_Cinemaroom> GetCinemaroom()
        {
            return Get().Tbl_CinemaRoom.ToList();
        }

        public List<Tbl_Roomseat> GetRoomSeat()
        {
            return Get().Tbl_RoomSeat.ToList();
        }

        public List<Tbl_Seatprice> GetSeatPrice()
        {
            return Get().Tbl_SeatPrice.ToList();
        }

        public List<BookingModel> GetBookingDetail()
        {
            return Get().bookingModels.ToList();
        }
    }
}
