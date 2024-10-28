namespace RapidApiProject.Models
{
    public class HotelSearchViewModel
    {
        public string dest_id { get; set; }
        public string city_name { get; set; }
        public DateTime checkinDate { get; set; }
        public DateTime checkoutDate { get; set; }
        public int adultCount { get; set; }

        public int roomCount { get; set; }

    }
}
