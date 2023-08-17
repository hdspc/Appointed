using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969
{
   public class Address
    {
        public int AddressID { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public int CityID { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }



        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }


        public Address(int addressID, string address1, string address2, int cityID, string postalCode, string phoneNumber, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            AddressID = addressID;
            Address1 = address1;
            Address2 = address2;
            CityID = cityID;
            PostalCode = postalCode;
            PhoneNumber = phoneNumber;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;


        }



    }
}
