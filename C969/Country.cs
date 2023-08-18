using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
            
      

        public Country(int countryID, string country, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CountryID = countryID;
            CountryName = country;
        }

    }
}
