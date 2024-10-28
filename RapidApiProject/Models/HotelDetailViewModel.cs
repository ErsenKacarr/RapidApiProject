namespace RapidApiProject.Models
{
    public class HotelDetailViewModel
    {
        public Data data { get; set; }

        public class Data
        {
            public int ufi { get; set; }
            public int hotel_id { get; set; }
            public string hotel_name { get; set; }
            public string url { get; set; }
            public string hotel_name_trans { get; set; }
            public int review_nr { get; set; }
            public string arrival_date { get; set; }
            public string departure_date { get; set; }
            public string price_transparency_mode { get; set; }
            public string accommodation_type_name { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
            public string address { get; set; }
            public string address_trans { get; set; }
            public string city { get; set; }
            public string city_trans { get; set; }
            public string city_in_trans { get; set; }
            public string city_name_en { get; set; }
            public object district { get; set; }
            public string countrycode { get; set; }
            public float distance_to_cc { get; set; }
            public string default_language { get; set; }
            public string country_trans { get; set; }
            public string currency_code { get; set; }
            public string zip { get; set; }
            public string timezone { get; set; }
            public string rare_find_state { get; set; }
            public int soldout { get; set; }
            public int available_rooms { get; set; }
            public int max_rooms_in_reservation { get; set; }
            public string average_room_size_for_ufi_m2 { get; set; }
            public int is_family_friendly { get; set; }
            public int is_closed { get; set; }
            public int is_crimea { get; set; }
            public int is_hotel_ctrip { get; set; }
            public int is_price_transparent { get; set; }
            public int is_genius_deal { get; set; }
            public int is_cash_accepted_check_enabled { get; set; }
            public int qualifies_for_no_cc_reservation { get; set; }
            public int hotel_include_breakfast { get; set; }
            public string cc1 { get; set; }
            public string[] family_facilities { get; set; }

            public string[] spoken_languages { get; set; }

            public object[] available_deal_descriptions { get; set; }
            public object[] tax_exceptions { get; set; }

            public object[] free_facilities_cancel_breakfast { get; set; }

            public int[] districts { get; set; }
            public object[] preferences { get; set; }

            public Photo[] photos { get; set; }
        }


        public class Photo
        {
            public string url_max750 { get; set; }
            public string url_square180 { get; set; }
            public float ratio { get; set; }
            public string url_original { get; set; }
            public string url_square60 { get; set; }
            public int photo_id { get; set; }
            public string url_640x200 { get; set; }
            public int new_order { get; set; }
            public string last_update_date { get; set; }
            public string url_max300 { get; set; }
            public string url_max1280 { get; set; }
        }


    }
}
