using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace aerHealth
{
    public partial class PatientLogin : Form
    {
        static int attempt = 3;

        public PatientLogin()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(4500);
            InitializeComponent();
            t.Abort();
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        public void StartForm()
        {
            Application.Run(new Splash());
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userName(object sender, EventArgs e)
        {
            userNameBox.Clear();
        }

        private void password(object sender, EventArgs e)
        {
            passwordBox.Clear();
            passwordBox.PasswordChar = '*';
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (attempt == 0)
            {
                attemptsLabel.Text = ("        Out of Attempts");
                btnLogin.Enabled = false;
                return;
            }
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source = AER\SQLEXPRESS; Initial Catalog = BRMC; Integrated Security = True";

            SqlCommand scmd = new SqlCommand("select count (*) as cnt from dbo.Users where username=@usr and password=HASHBYTES('SHA1',CONVERT(nvarchar(4000),@pwd))", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", userNameBox.Text);
            scmd.Parameters.AddWithValue("@pwd", passwordBox.Text);
            scn.Open();

            if (scmd.ExecuteScalar().ToString() == "1")
            {
                this.Hide();
                PatientUI patient = new PatientUI();
                patient.ShowDialog();
                this.Close();
            }
            else
            {
                attemptsLabel.Text = ("You have" + " " + Convert.ToString(attempt) + " attempts left.");
                --attempt;
                userNameBox.Clear();
                passwordBox.Clear();
            }
            scn.Close();
        }

        private void buttonPhysicianClick(object sender, EventArgs e)
        {
            this.Hide();
            PhysicianLogin physicianLogin = new PhysicianLogin();
            physicianLogin.ShowDialog();
            this.Close();
        }

        private void registerButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }

    
    }
}
