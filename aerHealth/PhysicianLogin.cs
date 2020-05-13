using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace aerHealth
{
    public partial class PhysicianLogin : Form
    {
        static int attempt = 3;
        public PhysicianLogin()
        {
            InitializeComponent();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientLogin patientLogin = new PatientLogin();
            patientLogin.ShowDialog();
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (attempt == 0)
            {
                attemptsLabel.Text = ("Out of Attempts");
                loginButton.Enabled = false;
                return;
            }
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=AER\SQLEXPRESS;Initial Catalog=BRMC;Integrated Security=True";
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from dbo.Users where username=@usr and password=HASHBYTES('SHA1', CONVERT(nvarchar(4000),@pwd))", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", usr.Text);
            scmd.Parameters.AddWithValue("@pwd", password.Text);
            scn.Open();

            if (scmd.ExecuteScalar().ToString() == "1")
            {
                this.Hide();
                PhysicianUI physicianUI = new PhysicianUI();
                physicianUI.ShowDialog();
                this.Close();
            }
            else
            {
                usr.Clear();
                password.Clear();
                attemptsLabel.Text = ("You have" + " " + Convert.ToString(attempt) + " attempts left.");
                --attempt;
            }
            scn.Close();
        
        }   
    }
}
