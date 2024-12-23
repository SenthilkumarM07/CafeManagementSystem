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
    public partial class Admin_page : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog =cafe;integrated security=true";

        public Admin_page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            login_page l = new login_page();
            l.Show();
            this.Hide();
        }

        private void Admin_page_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            item_page i = new item_page();
            i.Show();
            this.Hide();
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdminShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                da = new SqlDataAdapter("select * from mycafe ", con);
                dt = new DataTable();
                da.Fill(dt);
                dgvAdmin.DataSource = dt;
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

        private void btnAdminDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("delete from mycafe where id=@id ", con);
                cmd.Parameters.AddWithValue("@id", txtAdminDeleteId.Text);
                int res = cmd.ExecuteNonQuery();
                if( res>0)
                {
                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Not deleted");
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

        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                da = new SqlDataAdapter("select * from mycafe where id=@id ", con);
                da.SelectCommand.Parameters.AddWithValue("@id",txtAdminSearchId.Text);
                dt = new DataTable();
                da.Fill(dt);
                dgvAdmin.DataSource = dt;
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

        private void dgvAdmin_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.Show();
            this.Hide();
        }
    }
}
