namespace ProjectIdeasWithDotNet8.MovieTicketOnlineBookingSystem.Models
{
    public class MovieResponseModel
    {
        public Tbl_Cinemalist[] Tbl_CinemaList { get; set; }
        public Tbl_Cinemaroom[] Tbl_CinemaRoom { get; set; }
        public Tbl_Movielist[] Tbl_MovieList { get; set; }
        public Tbl_Roomseat[] Tbl_RoomSeat { get; set; }
        public Tbl_Movieshowdate[] Tbl_MovieShowDate { get; set; }
        public Tbl_Movieschedule[] Tbl_MovieSchedule { get; set; }
        public Tbl_Seatprice[] Tbl_SeatPrice { get; set; }
        public List<BookingModel> bookingModels { get; set; }
    }

    public class Tbl_Cinemalist
    {
        public int CinemaId { get; set; }
        public string CinemaName { get; set; }
        public string CinemaLocation { get; set; }
    }

    public class Tbl_Cinemaroom
    {
        public int RoomId { get; set; }
        public int CinemaId { get; set; }
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }
        public int SeatingCapacity { get; set; }
    }

    public class Tbl_Movielist
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Duration { get; set; }
        public string MoviePhoto { get; set; }
    }

    public class Tbl_Roomseat
    {
        public int SeatId { get; set; }
        public int RoomId { get; set; }
        public int? SeatNo { get; set; }
        public string RowName { get; set; }
        public string SeatType { get; set; }
    }

    public class Tbl_Movieshowdate
    {
        public int ShowDateId { get; set; }
        public int CinemaId { get; set; }
        public int RoomId { get; set; }
        public int MovieId { get; set; }
    }

    public class Tbl_Movieschedule
    {
        public int ShowId { get; set; }
        public int ShowDateId { get; set; }
        public DateTime ShowDateTime { get; set; }
    }

    public class Tbl_Seatprice
    {
        public int SeatPriceId { get; set; }
        public int RoomId { get; set; }
        public string RowName { get; set; }
        public int SeatPrice { get; set; }
    }

    public class BookingModel
    {
        public Guid BookingId { get; set; }
        public int RoomId { get; set; }
        public int SeatId { get; set; }
        public string SeatNo { get; set; }
        public string RowName { get; set; }
        public string SeatType { get; set; }
        public int SeatPrice { get; set; }
        public DateTime ShowDate { get; set; }
    }
}
