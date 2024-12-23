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
    public partial class Order_page : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog=cafe;integrated security=true";

        public Order_page()
        {
            InitializeComponent();
        }

        private void btnOrderUpdateAccount_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.Show();
            this.Hide();
        }

        private void lblOrderLogOut_Click(object sender, EventArgs e)
        {
            login_page l = new login_page();
            l.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Order_page_Load(object sender, EventArgs e)
        {
            display();
        }

        void display()
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                da = new SqlDataAdapter("select  item_name , item_price from items", con);
                dt = new DataTable();
                da.Fill(dt);
                dgvMenuCard.DataSource = dt;
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

        private void btnOrderAddToCart_Click(object sender, EventArgs e)
        {
            display();
            
        }

        int n = 0;
        int amount = 0;
        int total = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            txtOrderItemName.Clear();
            numericUpDown1.Value=0;
            txtOrderUnitPrice.Clear();
            txtTotalPrice.Clear();
        }

        private void dgvMenuCard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           // numericUpDown1.Value=0;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            amount = int.Parse(dgvBill.Rows[e.RowIndex].Cells[4].Value.ToString());
        }


        private void btnOrderPlaceTheOrder_Click(object sender, EventArgs e)
        {
            if(txtTotalPrice.Text !="" && txtTotalPrice.Text!="0" )
            {
                n = dgvBill.Rows.Add();
                dgvBill.Rows[n].Cells[0].Value = dateTimePicker1.Text;
                dgvBill.Rows[n].Cells[1].Value = txtOrderItemName.Text;
                dgvBill.Rows[n].Cells[2].Value = txtOrderUnitPrice.Text;
                dgvBill.Rows[n].Cells[3].Value = numericUpDown1.Value;
                dgvBill.Rows[n].Cells[4].Value = txtTotalPrice.Text;
                total = total + int.Parse(txtTotalPrice.Text);
                button4.Text = "Rs" + total;
            }

            else
            {
                MessageBox.Show("select a quantity");
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0 && txtOrderUnitPrice.Text != "")
            {
                Int64 qun = Int64.Parse(numericUpDown1.Value.ToString());
                Int64 price = Int64.Parse(txtOrderUnitPrice.Text);
                txtTotalPrice.Text = (qun * price).ToString();
            }
            else if (txtOrderItemName.Text=="" && txtOrderUnitPrice.Text=="")
            {
                numericUpDown1.Value = 0;
            }

        }

        private void dgvMenuCard_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMenuCard.Rows[e.RowIndex];

                txtOrderItemName.Text = row.Cells["item_name"].Value.ToString();
                txtOrderUnitPrice.Text = row.Cells["item_price"].Value.ToString();
            }
        }

        private void cmbOrderCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                da = new SqlDataAdapter("select  item_name , item_price from items where item_category=@category", con);
                da.SelectCommand.Parameters.AddWithValue("@category", cmbOrderCategory.Text);
                dt = new DataTable();
                da.Fill(dt);
                dgvMenuCard.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text != "0" && txtTotalPrice.Text != "")
            {
                Finalpage f = new Finalpage();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select Atlest On Item");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

    }
}
