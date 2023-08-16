using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969.Exceptions
{
    public class AppointmentTimesInvalidException : Exception
    {
        public AppointmentTimesInvalidException(string error) : base(/*"Check appointment times. Business hours are 8am-5pm PST."*/error)
        {
        }


    }
}
