using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserBAL;
namespace DAL
{
    public class UserLoginDAL
    {

        public bool ValidateUser(UserLogin loginData)
        {
            bool status = false;
            SqlConnection cn = new SqlConnection("Data Source=spd\\sqlexpress;Initial Catalog=HydCollegeDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select [dbo].[ValidateUserLogin](@username,@pwd)", cn);
            cmd.Parameters.AddWithValue("@username", loginData.Username);
             cmd.Parameters.AddWithValue("@pwd", loginData.Password);

            cn.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (Convert.ToInt32(dr[0])==1)
                {
                    status = false;
                }
                else
                {
                    status = true;
                }
            }

            cn.Close();
            return status;
        }
    }
}
