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
    public partial class Treatments : UserControl
    {
        string connectionString = "Data Source=AER\\SQLEXPRESS;Initial Catalog=rehTherapy;Integrated Security=True";
        public Treatments()
        {
            InitializeComponent();
        }

        private void ButtonTreatment_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from patienttreatment", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgvTreatment.DataSource = dtbl;
            }
        }
    }
}
