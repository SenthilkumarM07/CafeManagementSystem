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
    public partial class item_page : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog=cafe;integrated security=true";

        public item_page()
        {
            InitializeComponent();
        }

        private void btnManageItemBack_Click(object sender, EventArgs e)
        {
            Admin_page a = new Admin_page();
            a.Show();
            this.Hide();
        }

        private void txtManageItemsCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void item_page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                da = new SqlDataAdapter("select * from items",con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void btnManageAdd_Click(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("insert into items values(@item_number,@item_name,@item_category,@item_price)",con);
                cmd.Parameters.AddWithValue("@item_number",txtManageItemsNumber.Text);
                cmd.Parameters.AddWithValue("@item_name", txtManageItemsName.Text);
                cmd.Parameters.AddWithValue("@item_category",txtManageItemsCategory.Text);
                cmd.Parameters.AddWithValue("@item_price",txtManageItemsPrice.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("item added sucesssfully");
                }
                else
                {
                    MessageBox.Show("item  not added");
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

        private void btnManageEdit_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("update items set item_name=@item_name,item_category=@item_category,item_price=@item_price where item_number=@item_number", con);
                cmd.Parameters.AddWithValue("@item_number", txtManageItemsNumber.Text);
                cmd.Parameters.AddWithValue("@item_name", txtManageItemsName.Text);
                cmd.Parameters.AddWithValue("@item_category", txtManageItemsCategory.Text);
                cmd.Parameters.AddWithValue("@item_price", txtManageItemsPrice.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("item updated sucesssfully");
                }
                else
                {
                    MessageBox.Show("item  not updated");
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

        private void btnManageDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("delete from items where item_number=@item_number", con);
                cmd.Parameters.AddWithValue("@item_number", txtManageItemsNumber.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("item deleted sucesssfully");
                }
                else
                {
                    MessageBox.Show("item  not deleted");
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
