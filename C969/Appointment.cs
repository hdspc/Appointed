using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969
{
   public abstract class Appointment
    {

        public int AppointmentID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string URL { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } 
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        public Appointment() { }

        // Appointment Constructor

        public Appointment(int appointmentID, int customerID, int userID, string type, DateTime start/* , string description, string location, string contact, string type, string url,  DateTime end, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy*/)
        {
            AppointmentID = appointmentID;
            CustomerID = customerID;
            UserID = userID;
            Type = type;
            Start = start;

            /*
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            URL = url;
            End = end;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
            */

        }

        //FROM WEBINARS


        private static BindingList<Appointment> Appointments = new BindingList<Appointment>();
    }
}
