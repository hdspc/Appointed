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
    public partial class EditAppointment : Form
    {
        public EditAppointment(Appointment appointment)
        {
            InitializeComponent();
            txt_CustomerID.Text = appointment.CustomerID.ToString();
             txt_UserID.Text = appointment.UserID.ToString();
            txt_AppointmentID.Text = appointment.AppointmentID.ToString();


            txt_Description.Text = appointment.Description;



            //////datetime_AppointmentStart.Format = appointment.Start.GetDateTimeFormats();
            //////datetime_AppointmentEnd.Format = appointment.End;
            txt_CreatedDate.Text = appointment.CreateDate.ToString();
            txt_CreatedBy.Text = appointment.CreatedBy.ToString();
            txt_LastUpdate.Text = appointment.LastUpdateBy.ToString();
        }
    }
}
