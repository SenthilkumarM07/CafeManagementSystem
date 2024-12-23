using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_management
{
    public partial class login_page : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog =cafe;integrated security=true";

        public login_page()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblLoginSignUp_Click(object sender, EventArgs e)
        {
            signup_page s = new signup_page();
            s.Show();
            this.Hide();
        }

        private void btnLoginClear_Click(object sender, EventArgs e)
        {
            txtLoginPassword.Clear();
            txtLoginUserName.Clear();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtLoginUserName.Text)||string.IsNullOrEmpty(txtLoginPassword.Text))
            {
                MessageBox.Show("fill all the text box");
            }
            else if(txtLoginUserName.Text=="Admin" && txtLoginPassword.Text=="Admin123")
            {
                Admin_page a=new Admin_page();
                a.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    con = new SqlConnection(s);
                    con.Open();
                    cmd=new SqlCommand("select * from mycafe where username=@username and password =@password",con);
                    cmd.Parameters.AddWithValue("@username",txtLoginUserName.Text);
                    cmd.Parameters.AddWithValue("@password",txtLoginPassword.Text);
                    dr=cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Order_page o = new Order_page();
                        o.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("invalid username  or password");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
