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
using System.Net.Mail;
using System.Net;

namespace aerHealth
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void fNameClick(object sender, EventArgs e)
        {
            fNameBox.Clear();
        }

        private void lNameClick(object sender, EventArgs e)
        {
            lNameBox.Clear();
        }

        private void userNameClick(object sender, EventArgs e)
        {
            usernameBox.Clear();
        }

        private void passwordClick(object sender, EventArgs e)
        {
            passwordBox.Clear();
            passwordBox.PasswordChar = '*';
        }

        private void exitButton(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rePasswordClick(object sender, EventArgs e)
        {
            rePasswordBox.Clear();
            rePasswordBox.PasswordChar = '*';
        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            PatientLogin patientLogin = new PatientLogin();
            patientLogin.ShowDialog();
            this.Close();
        }

        private void createButtonClick(object sender, EventArgs e)
        {
            string strEmail = emailBox.Text;
            string strUser = usernameBox.Text;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("<your-email-here");
            mail.To.Add(new MailAddress(strEmail));
            mail.Subject = "Welcome to aerHealth";
            mail.Body = "Congratulations, " + strUser + "!" + "\n" + "You are one step closer to getting the best care that you deserve!" +
                "\n" + "Thank you for registering with us."
                + "\n"
                + "\n"
                + "Sincerely," + "\n" + "aerHealth"
                +
                @"
       .....           .....
   ,ad8PPPP88b,     ,d88PPPP8ba,
  d8P'      'Y8b, ,d8P'      'Y8b
 dP'           '8a8'           `Yd
 8('                            ')8
 I8                             8I
  Yb,                         , dP
   '8a,                     ,a8'
     '8a,                 ,a8'
       'Yba             adP''   
         `Y8a         a8P'
           `88,     , 88'
             '8b   d8'
              '8b d8'
               `888'
                 ' "
                ;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("your-email-here", "your-password-here");

            try
            {
                smtp.Send(mail);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            createButton.Enabled = false;

            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=AER\SQLEXPRESS;Initial Catalog=BRMC;Integrated Security=True";

            string query = "Select * from users where username='" + usernameBox.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, scn);

            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                MessageBox.Show("Please choose a different username");

                return;
            }

            else if (fNameBox.Text == "" || lNameBox.Text == "" || usernameBox.Text == "" || passwordBox.Text == "" | rePasswordBox.Text == "" || emailBox.Text == "")
            {
                MessageBox.Show("Please do not leave any fields blank.");

                return;
            }
            else if (fNameBox.Text == "First Name" || lNameBox.Text == "Last Name" || usernameBox.Text == "Username" || emailBox.Text == "E-mail" || passwordBox.Text == "Password" || rePasswordBox.Text == "Re-type Password")
            {
                MessageBox.Show("Please enter values for the required fields");
                return;
            }
            else if (passwordBox.Text != rePasswordBox.Text)
            {
                MessageBox.Show("Passwords do not match.");

                return;
            }
            else
            {
                Utility.AddUser(fNameBox.Text, lNameBox.Text, usernameBox.Text, passwordBox.Text, emailBox.Text);
            }

            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            this.Close();
        }

        private void emailClick(object sender, EventArgs e)
        {
            emailBox.Clear();
        }
    }
}
