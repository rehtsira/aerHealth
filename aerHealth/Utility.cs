using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace aerHealth
{
    class Utility
    {
        public static void AddUser(string username, string password, string firstname, string lastname, string emailaddress)
        {
            using (SqlConnection openCon = new SqlConnection(ConfigurationManager.ConnectionStrings["BRMC"].ConnectionString))
            {
                SqlCommand querySaveStaff = new SqlCommand("INSERT into users (Username,Password,FirstName,LastName,EmailAddress) VALUES (@Username,HASHBYTES('SHA1', CONVERT(nvarchar(4000),@Password)),@FirstName,@LastName,@EmailAddress)", openCon);
                querySaveStaff.Parameters.Add("@Username", SqlDbType.VarChar);
                querySaveStaff.Parameters["@Username"].Value = username;
                querySaveStaff.Parameters.Add("@Password", SqlDbType.VarChar);
                querySaveStaff.Parameters["@Password"].Value = password;
                querySaveStaff.Parameters.Add("@FirstName", SqlDbType.VarChar);
                querySaveStaff.Parameters["@FirstName"].Value = firstname;
                querySaveStaff.Parameters.Add("@LastName", SqlDbType.VarChar);
                querySaveStaff.Parameters["@LastName"].Value = lastname;
                querySaveStaff.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                querySaveStaff.Parameters["@EmailAddress"].Value = emailaddress;

                openCon.Open();
                querySaveStaff.ExecuteNonQuery();
                openCon.Close();
                querySaveStaff.Dispose();

            }
        }

        public static void AddPatient(string fName, string lName, string phone, string birth, string street, string city, string state, string zip)
        {
            using (SqlConnection openCon = new SqlConnection(ConfigurationManager.ConnectionStrings["rehTherapy"].ConnectionString))
            {
                SqlCommand querySaveStaff = new SqlCommand("INSERT into patient (firstName, lastName, phoneNumber, birthDate, streetAddress, City, state, zipCode) VALUES (@firstName, @lastName, @phoneNumber, @birthDate, @streetAddress, @City, @state, @zipCode)", openCon);
                querySaveStaff.Parameters.Add("@firstName", SqlDbType.VarChar);
                querySaveStaff.Parameters["@firstName"].Value = fName;
                querySaveStaff.Parameters.Add("@lastName", SqlDbType.VarChar);
                querySaveStaff.Parameters["@lastName"].Value = lName;
                querySaveStaff.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                querySaveStaff.Parameters["@phoneNumber"].Value = phone;
                querySaveStaff.Parameters.Add("@birthDate", SqlDbType.VarChar);
                querySaveStaff.Parameters["@birthDate"].Value = birth;
                querySaveStaff.Parameters.Add("@streetAddress", SqlDbType.VarChar);
                querySaveStaff.Parameters["@streetAddress"].Value = street;
                querySaveStaff.Parameters.Add("@City", SqlDbType.VarChar);
                querySaveStaff.Parameters["@City"].Value = city;
                querySaveStaff.Parameters.Add("@state", SqlDbType.VarChar);
                querySaveStaff.Parameters["@state"].Value = state;
                querySaveStaff.Parameters.Add("@zipCode", SqlDbType.VarChar);
                querySaveStaff.Parameters["@zipCode"].Value = zip;

                openCon.Open();
                querySaveStaff.ExecuteNonQuery();
                openCon.Close();
                querySaveStaff.Dispose();
            }
        }

        public static SqlDataReader GetAListOfUsers()
        {

            using (SqlConnection openCon = new SqlConnection())
            {


                using (SqlCommand querySaveStaff = new SqlCommand("select * from users"))
                {
                    querySaveStaff.Connection = openCon;

                    openCon.Open();
                    SqlDataReader results = querySaveStaff.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    return results;
                }
            }

        }
    }
}
