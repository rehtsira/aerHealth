using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aerHealth
{
    public partial class PatientUI : Form
    {
        public PatientUI()
        {
            InitializeComponent();
            timer.Enabled = true;
            SidePanel.Height = buttonHome.Height;
            welcomeControl.BringToFront();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string strTime;
            string strDate;

            strTime = DateTime.Now.ToLongDateString();
            strDate = DateTime.Now.ToLongTimeString();

            lblTime.Text = strTime + "   " + strDate;
        }

        private void homeButtonClick(object sender, EventArgs e)
        {
            SidePanel.Height = buttonHome.Height;
            SidePanel.Top = buttonHome.Height;
            welcomeControl.BringToFront();
        }

        private void appointmentButtonClick(object sender, EventArgs e)
        {
            SidePanel.Height = buttonAppointment.Height;
            SidePanel.Top = buttonAppointment.Height;
            appointmentControl.BringToFront();
        }

        private void facilitiesButtonClick(object sender, EventArgs e)
        {
            SidePanel.Height = buttonFacilities.Height;
            SidePanel.Top = buttonFacilities.Height;
            facilitiesControl.BringToFront();
        }

        private void billingButtonClick(object sender, EventArgs e)
        {
            SidePanel.Height = buttonBilling.Height;
            SidePanel.Top = buttonBilling.Height;
            billingControl.BringToFront();
        }

        private void logOffClick(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
