using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_management
{
    public partial class Update : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        string s= "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog=cafe;integrated security=true";
        public Update()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Admin_page a = new Admin_page();
            a.Show();
            this.Hide();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            update();
        }
        void update()
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("select id from mycafe",con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbUpdateId.Items.Add(dr[0]).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void cmbUpdateId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("select * from mycafe where id=@id", con);
                cmd.Parameters.AddWithValue("@id", cmbUpdateId.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtUpdateUserName.Text = dr[1].ToString();
                    txtUpdateMailId.Text = dr[2].ToString();
                    txtUpdatePhNumber.Text = dr[3].ToString();
                    txtUpdatePassword.Text = dr[4].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("update mycafe set username=@username,mailid=@mailid,ph_number=@phnumber,password=@password where id=@id",con);
                cmd.Parameters.AddWithValue("@username", txtUpdateUserName.Text);
                cmd.Parameters.AddWithValue("@mailid", txtUpdateMailId.Text);
                cmd.Parameters.AddWithValue("@phnumber",txtUpdatePhNumber.Text);
                cmd.Parameters.AddWithValue("@password",txtUpdatePassword.Text);
                cmd.Parameters.AddWithValue("id",cmbUpdateId.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("updated sucessfully");
                }
                else
                {
                    MessageBox.Show("not updated");
                }

            }

            catch (Exception ex)
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
