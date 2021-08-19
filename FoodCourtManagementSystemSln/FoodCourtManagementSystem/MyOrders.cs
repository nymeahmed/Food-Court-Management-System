using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodCourtManagementSystem
{
    public partial class MyOrders : Form
    {
        public MyOrders(string uname)
        {
            InitializeComponent();

            lblUname.Text = uname;
        }

        private void MyOrders_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckOrders_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string username = lblUname.Text;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select FoodType,FoodID,Cost from OrderList  where UserName='"+username+"'";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewOrders.DataSource = dt;
                dataGridViewOrders.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            btnBreakfast.BackColor = Color.Aqua;
            btnLunch.BackColor = Color.Silver;
            btnShawarma.BackColor = Color.Silver;
            btnPasta.BackColor = Color.Silver;
            btnPizza.BackColor = Color.Silver;
            btnBurger.BackColor = Color.Silver;
            btnDessert.BackColor = Color.Silver;
            btnSoup.BackColor = Color.Silver;
            btnDinner.BackColor = Color.Silver;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select FoodID,[FoodName/FoodID] from Breakfast";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnBreakfast.BackColor = Color.Silver;
            btnLunch.BackColor = Color.Silver;
            btnShawarma.BackColor = Color.Silver;
            btnPasta.BackColor = Color.Silver;
            btnPizza.BackColor = Color.Silver;
            btnBurger.BackColor = Color.Silver;
            btnDessert.BackColor = Color.Silver;
            btnSoup.BackColor = Color.Silver;
            btnDinner.BackColor = Color.Aqua;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select FoodID,[FoodName/FoodID] from Dinner";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            btnBreakfast.BackColor = Color.Silver;
            btnLunch.BackColor = Color.Aqua;
            btnShawarma.BackColor = Color.Silver;
            btnPasta.BackColor = Color.Silver;
            btnPizza.BackColor = Color.Silver;
            btnBurger.BackColor = Color.Silver;
            btnDessert.BackColor = Color.Silver;
            btnSoup.BackColor = Color.Silver;
            btnDinner.BackColor = Color.Silver;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select FoodID,[FoodName/FoodID] from Lunch";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnShawarma_Click(object sender, EventArgs e)
        {
            btnBreakfast.BackColor = Color.Silver;
            btnLunch.BackColor = Color.Silver;
            btnShawarma.BackColor = Color.Aqua;
            btnPasta.BackColor = Color.Silver;
            btnPizza.BackColor = Color.Silver;
            btnBurger.BackColor = Color.Silver;
            btnDessert.BackColor = Color.Silver;
            btnSoup.BackColor = Color.Silver;
            btnDinner.BackColor = Color.Silver;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select FoodID,[FoodName/FoodID] from Shawarma";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            btnBreakfast.BackColor = Color.Silver;
            btnLunch.BackColor = Color.Silver;
            btnShawarma.BackColor = Color.Silver;
            btnPasta.BackColor = Color.Aqua;
            btnPizza.BackColor = Color.Silver;
            btnBurger.BackColor = Color.Silver;
            btnDessert.BackColor = Color.Silver;
            btnSoup.BackColor = Color.Silver;
            btnDinner.BackColor = Color.Silver;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select FoodID,[FoodName/FoodID] from Pasta";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            btnBreakfast.BackColor = Color.Silver;
            btnLunch.BackColor = Color.Silver;
            btnShawarma.BackColor = Color.Silver;
            btnPasta.BackColor = Color.Silver;
            btnPizza.BackColor = Color.Aqua;
            btnBurger.BackColor = Color.Silver;
            btnDessert.BackColor = Color.Silver;
            btnSoup.BackColor = Color.Silver;
            btnDinner.BackColor = Color.Silver;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select FoodID,[FoodName/FoodID] from Pizza";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            btnBreakfast.BackColor = Color.Silver;
            btnLunch.BackColor = Color.Silver;
            btnShawarma.BackColor = Color.Silver;
            btnPasta.BackColor = Color.Silver;
            btnPizza.BackColor = Color.Silver;
            btnBurger.BackColor = Color.Aqua;
            btnDessert.BackColor = Color.Silver;
            btnSoup.BackColor = Color.Silver;
            btnDinner.BackColor = Color.Silver;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select FoodID,[FoodName/FoodID] from Burger";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            btnBreakfast.BackColor = Color.Silver;
            btnLunch.BackColor = Color.Silver;
            btnShawarma.BackColor = Color.Silver;
            btnPasta.BackColor = Color.Silver;
            btnPizza.BackColor = Color.Silver;
            btnBurger.BackColor = Color.Silver;
            btnDessert.BackColor = Color.Aqua;
            btnSoup.BackColor = Color.Silver;
            btnDinner.BackColor = Color.Silver;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select FoodID,[FoodName/FoodID] from Dessert";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSoup_Click(object sender, EventArgs e)
        {
            btnBreakfast.BackColor = Color.Silver;
            btnLunch.BackColor = Color.Silver;
            btnShawarma.BackColor = Color.Silver;
            btnPasta.BackColor = Color.Silver;
            btnPizza.BackColor = Color.Silver;
            btnBurger.BackColor = Color.Silver;
            btnDessert.BackColor = Color.Silver;
            btnSoup.BackColor = Color.Aqua;
            btnDinner.BackColor = Color.Silver;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select FoodID,[FoodName/FoodID] from Soup";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
