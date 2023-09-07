using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
    public partial class AddUser : Form
    {
        private UserAccount _u;

        public AddUser(UserAccount u)
        {
            InitializeComponent();

            _u = u;

            txt_userID.Text = Database.DBConnection.GetNewIdFromTable("user", "userId").ToString();

        }


    }
}
