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
    public partial class signup_page : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog =cafe;integrated security=true";

        mycafeitems obj2 = new mycafeitems();
        mycafeuser obj1 = new mycafeuser();
        methods m = new methods();

        public signup_page()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSignUpLogin_Click(object sender, EventArgs e)
        {
            login_page l = new login_page();
            l.Show();
            this.Hide();
        }

        private void BtnSignUpClear_Click(object sender, EventArgs e)
        {
            txtSignUpUserName.Clear();
            txtSignUpPhNumber.Clear();
            txtSignUpMailId.Clear();
            txtSignUpPassword.Clear();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //sign up
            if (string.IsNullOrEmpty(txtSignUpPassword.Text) || string.IsNullOrEmpty(txtSignUpMailId.Text)
                || string.IsNullOrEmpty(txtSignUpPhNumber.Text) || string.IsNullOrEmpty(txtSignUpUserName.Text))
            {
                MessageBox.Show("Fill all textBox");
            }
            else
            {
                obj1.username = txtSignUpUserName.Text;
                obj1.ph_number = Convert.ToInt64(txtSignUpPhNumber.Text);
                obj1.mailid = txtSignUpMailId.Text;
                obj1.password = txtSignUpPassword.Text;
                int res = m.insert_method(obj1);
                if (res >= 1)
                {
                    MessageBox.Show("inserted successfully");
                }
                else
                {
                    MessageBox.Show("Not inserted");
                }

            }
           

        }
    }
}
