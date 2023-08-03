using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C969;

namespace C969.Events
{
    public class UserLogin : EventArgs
    {
        private UserAccount user;

        public UserAccount User
        {
            get { return user; }
        }

        public UserLogin(UserAccount user)
        {
            this.user = user;
        }
    }
}