using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace aerHealth
{
    public partial class PatientList : UserControl
    {
        string connectionString = "Data Source=AER\\SQLEXPRESS;Initial Catalog=rehTherapy;Integrated Security=True";
        public PatientList()
        {
            InitializeComponent();
        }

        private void patientListButtonClick(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from patient", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgvPatientList.DataSource = dtbl;
            }
        }

        private void FName_Click(object sender, EventArgs e)
        {
            fName.Clear();
        }

        private void LName_Click(object sender, EventArgs e)
        {
            lName.Clear();
        }

        private void Phone_Click(object sender, EventArgs e)
        {
            phone.Clear();
        }

        private void Birth_Click(object sender, EventArgs e)
        {
            birth.Clear();
        }

        private void Address_Click(object sender, EventArgs e)
        {
            address.Clear();
        }

        private void City_Click(object sender, EventArgs e)
        {
            city.Clear();
        }

        private void State_Click(object sender, EventArgs e)
        {
            state.Clear();
        }

        private void Zip_Click(object sender, EventArgs e)
        {
            zip.Clear();
        }

        private void PatientAddButton_Click(object sender, EventArgs e)
        {
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=AER\SQLEXPRESS;Initial Catalog=rehTherapy;Integrated Security=True";

            string query = "Select * from patient where firstName='" + fName.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, scn);

            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                MessageBox.Show("Name is already added");

                return;
            }

            else if (fName.Text == "" || lName.Text == "" || phone.Text == "" || birth.Text == "" | address.Text == "" || city.Text == "" || state.Text == "" || zip.Text == "")
            {
                MessageBox.Show("Please do not leave any fields blank.");

                return;
            }
            else if (fName.Text == "First Name" || lName.Text == "Last Name" || phone.Text == "Phone" || birth.Text == "Birthday" || address.Text == "Address" || city.Text == "City" || zip.Text == "Zip Code")
            {
                MessageBox.Show("Please enter values for the required fields");
                return;
            }
            
            else
            {
                Utility.AddPatient(fName.Text, lName.Text, phone.Text, birth.Text, address.Text, city.Text, state.Text, zip.Text);
            }
        }
    }
}
