using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace cafe_management
{
    class methods
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog=cafe;integrated security=true";

        public int insert_method(mycafeuser objuser)
        {
            int res = 0;
            //if (string.IsNullOrEmpty(objuser.username) || string.IsNullOrEmpty(objuser.mailid)
            //    || string.IsNullOrEmpty(objuser.ph_number)|| string.IsNullOrEmpty(objuser.password))
            //{}
            //else
            //{
              try
                {
                    con = new SqlConnection(s);
                    con.Open();
                    cmd = new SqlCommand("insert into mycafe values(@username,@mailid,@ph_number,@password)", con);
                    cmd.Parameters.AddWithValue("username", objuser.username);
                    cmd.Parameters.AddWithValue("mailid", objuser.mailid);
                    cmd.Parameters.AddWithValue("@ph_number", objuser.ph_number);
                    cmd.Parameters.AddWithValue("@password", objuser.password);
                    res = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    con.Close();
            
        
            }
                return res;
        }
    }
}
