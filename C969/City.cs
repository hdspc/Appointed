using System;

namespace C969
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int CountryID { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }


        public City(int cityID, string city, int countryID, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CityID = cityID;
            CityName = city;
            CountryID = countryID;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
    }
}
