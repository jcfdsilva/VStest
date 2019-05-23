using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDB
    {

        //Add new quotas by username
        public static int addQuotaByUsername(string username, float quota)
        {
            int result = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["REST_G3"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE [User]" +
                                        "SET " +
                                            "Credit = Credit + @quota " +
                                         "WHERE " +
                                            "Username = @username ";

                    SqlCommand cmd = new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@quota", quota);
                    cmd.Parameters.AddWithValue("@username", username);

                    cn.Open();

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public static float getQuotaByUID(String user)
        {
            float quota = -1;
            string connectionString = ConfigurationManager.ConnectionStrings["REST_G3"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Select Credit from [User] where Uid=@userUID";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@userUID", user);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            quota = Convert.ToSingle(dr["Credit"]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return quota;
        }

        public static float getQuotaByUser(String user)
        {
            float quota = -1;
            string connectionString = ConfigurationManager.ConnectionStrings["REST_G3"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Select Credit from [User] where Username=@username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", user);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            quota = Convert.ToSingle(dr["Credit"]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return quota;
        }

        public static string getUsernameByUID(string userUID)
        {
            string username = "";
            string connectionString = ConfigurationManager.ConnectionStrings["REST_G3"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Select Username from [User] WHERE Uid = @userUID ";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@userUID", userUID);


                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            username = (string)dr["Username"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return username;
        }


    }

}
