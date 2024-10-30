namespace RapidApiProject.Models
{
    public class HotelListViewModel
    {
        public Data data { get; set; }

        public class Data
        {
            public Hotel[] hotels { get; set; }
            public Meta[] meta { get; set; }
            public Appear[] appear { get; set; }
        }

        public class Hotel
        {
            public int hotel_id { get; set; }
            public string accessibilityLabel { get; set; }
            public Property1 property { get; set; }
        }

        public class Property1
        {
            public string[] photoUrls { get; set; }
            public int mainPhotoId { get; set; }
            public string currency { get; set; }
            public int position { get; set; }
            public bool isFirstPage { get; set; }
            public int id { get; set; }
            public string checkoutDate { get; set; }
            public string wishlistName { get; set; }
            public Pricebreakdown priceBreakdown { get; set; }
            public float reviewScore { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
            public int optOutFromGalleryChanges { get; set; }
            public string countryCode { get; set; }
            public int ufi { get; set; }
            public string checkinDate { get; set; }
            public Checkout checkout { get; set; }
            public int rankingPosition { get; set; }
            public int propertyClass { get; set; }
            public int reviewCount { get; set; }
            public string name { get; set; }
            public int qualityClass { get; set; }
            public Checkin checkin { get; set; }
            public int accuratePropertyClass { get; set; }
            public string reviewScoreWord { get; set; }
            public string[] blockIds { get; set; }
            public bool isPreferred { get; set; }
            public bool isPreferredPlus { get; set; }
        }

        public class Pricebreakdown
        {
            public Strikethroughprice strikethroughPrice { get; set; }
            public Grossprice grossPrice { get; set; }
            public Benefitbadge[] benefitBadges { get; set; }
            public object[] taxExceptions { get; set; }
            public Excludedprice excludedPrice { get; set; }
        }

        public class Strikethroughprice
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Grossprice
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Excludedprice
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Benefitbadge
        {
            public string variant { get; set; }
            public string identifier { get; set; }
            public string explanation { get; set; }
            public string text { get; set; }
        }

        public class Checkout
        {
            public string fromTime { get; set; }
            public string untilTime { get; set; }
        }

        public class Checkin
        {
            public string untilTime { get; set; }
            public string fromTime { get; set; }
        }

        public class Meta
        {
            public string title { get; set; }
        }

        public class Appear
        {
            public Component component { get; set; }
            public string id { get; set; }
            public string contentUrl { get; set; }
            public string accessibilityLabel { get; set; }
        }

        public class Component
        {
            public Props props { get; set; }
        }

        public class Props
        {
            public bool fill { get; set; }
            public Content content { get; set; }
            public string title { get; set; }
            public string text { get; set; }
            public Item2[] items { get; set; }
        }

        public class Content
        {
            public Props1 props { get; set; }
        }

        public class Props1
        {
            public bool fitContentWidth { get; set; }
            public Item[] items { get; set; }
        }

        public class Item
        {
            public Props2 props { get; set; }
        }

        public class Props2
        {
            public Component1 component { get; set; }
        }

        public class Component1
        {
            public Props3 props { get; set; }
        }

        public class Props3
        {
            public Item1[] items { get; set; }
            public string spacing { get; set; }
            public string tertiaryTintedColor { get; set; }
            public string icon { get; set; }
            public string variant { get; set; }
            public string accessibilityLabel { get; set; }
        }

        public class Item1
        {
            public Props4 props { get; set; }
        }

        public class Props4
        {
            public Text[] text { get; set; }
        }

        public class Text
        {
            public string font { get; set; }
            public string text { get; set; }
            public string color { get; set; }
            public Linkaction[] linkActions { get; set; }
        }

        public class Linkaction
        {
            public Props5 props { get; set; }
        }

        public class Props5
        {
            public string url { get; set; }
            public Experiment experiment { get; set; }
            public int goalIndex { get; set; }
        }

        public class Experiment
        {
            public string uvi { get; set; }
            public int variant { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public bool shouldTrack { get; set; }
            public string uviType { get; set; }
        }

        public class Item2
        {
            public Props6 props { get; set; }
        }

        public class Props6
        {
            public Component2 component { get; set; }
            public int width { get; set; }
        }

        public class Component2
        {
            public Props7 props { get; set; }
        }

        public class Props7
        {
            public string cornerRadius { get; set; }
            public Component3 component { get; set; }
            public Item3[] items { get; set; }
        }

        public class Component3
        {
            public Props8 props { get; set; }
        }

        public class Props8
        {
            public string source { get; set; }
        }

        public class Item3
        {
            public Props9 props { get; set; }
        }

        public class Props9
        {
            public Item7[] items { get; set; }
            public Component4 component { get; set; }
        }

        public class Component4
        {
            public Props10 props { get; set; }
        }

        public class Props10
        {
            public string score { get; set; }
            public string title { get; set; }
            public string size { get; set; }
            public string subtitle { get; set; }
            public bool inline { get; set; }
            public Item4[] items { get; set; }
            public string spacing { get; set; }
            public string alignment { get; set; }
        }

        public class Item4
        {
            public Props11 props { get; set; }
        }

        public class Props11
        {
            public Component5 component { get; set; }
            public Text1[] text { get; set; }
            public string alignment { get; set; }
            public Item6[] items { get; set; }
        }

        public class Component5
        {
            public Props12 props { get; set; }
        }

        public class Props12
        {
            public Item5[] items { get; set; }
            public string spacing { get; set; }
        }

        public class Item5
        {
            public Props13 props { get; set; }
        }

        public class Props13
        {
            public Component6 component { get; set; }
            public string text { get; set; }
        }

        public class Component6
        {
            public Props14 props { get; set; }
        }

        public class Props14
        {
            public string name { get; set; }
            public string size { get; set; }
        }

        public class Text1
        {
            public string text { get; set; }
            public string font { get; set; }
            public string color { get; set; }
            public bool strikethrough { get; set; }
        }

        public class Item6
        {
            public Props15 props { get; set; }
        }

        public class Props15
        {
            public string alignment { get; set; }
            public string color { get; set; }
            public string text { get; set; }
            public string font { get; set; }
        }

        public class Item7
        {
            public Props16 props { get; set; }
        }

        public class Props16
        {
            public string spacing { get; set; }
            public Item8[] items { get; set; }
            public Component7 component { get; set; }
        }

        public class Component7
        {
            public Props17 props { get; set; }
        }

        public class Props17
        {
            public string wishlistName { get; set; }
            public int propertyId { get; set; }
            public string destinationId { get; set; }
        }

        public class Item8
        {
            public Props18 props { get; set; }
        }

        public class Props18
        {
            public string font { get; set; }
            public string text { get; set; }
            public Item9[] items { get; set; }
        }

        public class Item9
        {
            public Props19 props { get; set; }
        }

        public class Props19
        {
            public Component8 component { get; set; }
        }

        public class Component8
        {
            public Props20 props { get; set; }
        }

        public class Props20
        {
            public int value { get; set; }
            public string size { get; set; }
            public string name { get; set; }
        }
    }
}
