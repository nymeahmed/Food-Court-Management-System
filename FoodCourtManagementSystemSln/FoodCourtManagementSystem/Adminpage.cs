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
using System.Security;

namespace FoodCourtManagementSystem
{
    public partial class Adminpage : Form
    {
        public Adminpage(string value1,string value2) // for getting the username
        {
            InitializeComponent();

            lblWelcome.Visible = true; 
            lblUname.Text = value1; //admin username
            lblUname.Visible = true;

            lblPassword.Text = value2; //admin password
        }
        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Adminpage_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            btnUserInfo.BackColor = Color.Aqua;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select UserName,Password,Phone,Email,Area,Address from UserInfo";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewUser.DataSource = dt;
                dataGridViewUser.Refresh();
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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select Username,Password from [Admin]";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewAdmin.DataSource = dt;
                dataGridViewAdmin.Refresh();
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

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            AddAdmin aa = new AddAdmin();
            aa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AdminPassChange aa = new AdminPassChange(lblUname.Text,lblPassword.Text); //pass uname,password
            aa.ShowDialog();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblUname_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnConfirm.Text = "Confirm";
            btnConfirm.BackColor = Color.Red;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select Username from [Admin]";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];

                

                deletetxtbox.Visible = true;
                btnConfirm.Visible = true;
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (btnConfirm.BackColor == Color.Green)
            {
                MessageBox.Show("Please click 'Delete Admin?' button first");
            }
            else
            {
                string uname = deletetxtbox.Text;

                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                    conn.Open();

                    string query = "select Username from [Admin] where Username = '" + uname + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    string dbUname = dt.Rows[0]["Username"].ToString();
                    if (uname == dbUname)
                    {
                        //MessageBox.Show("successful");
                        string query2 = "delete from [Admin] where Username = '" + uname + "'";
                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                        cmd2.ExecuteNonQuery();

                        btnConfirm.BackColor = Color.Green;
                        btnConfirm.Text = "Deleted";
                        deletetxtbox.Visible = false;
                        //btnConfirm.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Admin username doesn't match");
                    }

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("Admin username doesn't match");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void cmdDelete_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void deletetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

                string query = "select FoodID,[FoodName/FoodID],Price from Breakfast";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewList.DataSource = dt;
                dataGridViewList.Refresh();
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

        private void button4_Click(object sender, EventArgs e)
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

                string query = "select FoodID,[FoodName/FoodID],Price from Burger";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewList.DataSource = dt;
                dataGridViewList.Refresh();
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

        private void btnOrders_Click(object sender, EventArgs e)
        {
            btnOrders.BackColor = Color.Aqua;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select UserName,FoodType,FoodID,Cost from OrderList";
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

                string query = "select FoodID,[FoodName/FoodID],Price from Lunch";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewList.DataSource = dt;
                dataGridViewList.Refresh();
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

                string query = "select FoodID,[FoodName/FoodID],Price from Shawarma";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewList.DataSource = dt;
                dataGridViewList.Refresh();
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

                string query = "select FoodID,[FoodName/FoodID],Price from Pasta";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewList.DataSource = dt;
                dataGridViewList.Refresh();
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

                string query = "select FoodID,[FoodName/FoodID],Price from Pizza";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewList.DataSource = dt;
                dataGridViewList.Refresh();
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

                string query = "select FoodID,[FoodName/FoodID],Price from Dessert";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewList.DataSource = dt;
                dataGridViewList.Refresh();
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

                string query = "select FoodID,[FoodName/FoodID],Price from Soup";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewList.DataSource = dt;
                dataGridViewList.Refresh();
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

        private void btnDinner_Click(object sender, EventArgs e)
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

                string query = "select FoodID,[FoodName/FoodID],Price from Dinner";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewList.DataSource = dt;
                dataGridViewList.Refresh();
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
