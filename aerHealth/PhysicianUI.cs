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
    public partial class PhysicianUI : Form
    {
        public PhysicianUI()
        {
            InitializeComponent();
            timer.Enabled = true;
            SidePanel.Height = buttonPatients.Height;
            patientControl.BringToFront();
        }

        private void ButtonLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string strTime;
            string strDate;

            strTime = DateTime.Now.ToLongDateString();
            strDate = DateTime.Now.ToLongTimeString();

            lblTime.Text = strTime + "   " + strDate;
        }

        private void patientButtonClick(object sender, EventArgs e)
        {
            SidePanel.Height = buttonPatients.Height;
            SidePanel.Top = buttonPatients.Height;
            patientControl.BringToFront();
        }

        private void buttonTreatmentsClick(object sender, EventArgs e)
        {
            SidePanel.Height = buttonTreatments.Height;
            SidePanel.Top = buttonTreatments.Height;
            treatmentsControl.BringToFront();
        }

        private void appointmentButtonClick(object sender, EventArgs e)
        {
            SidePanel.Height = buttonAppointments.Height;
            SidePanel.Top = buttonAppointments.Height;
            appointmentControl.BringToFront();
        }

        private void physicianButtonClick(object sender, EventArgs e)
        {
            SidePanel.Height = buttonPhysicians.Height;
            SidePanel.Top = buttonPhysicians.Height;
            physiciansControl.BringToFront();
        }

        private void billingButtonClick(object sender, EventArgs e)
        {
            SidePanel.Height = buttonBilling.Height;
            SidePanel.Top = buttonBilling.Height;
            billingControl.BringToFront();
        }
    }
}
