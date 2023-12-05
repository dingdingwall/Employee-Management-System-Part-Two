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
using System.Data.Sql;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Employee_Management_System_Part_Two
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DCPNVH9\\SQLEXPRESS;Initial Catalog=EMS_DATABASE;Integrated Security=True");

        private void Login_Load(object sender, EventArgs e)
        {
        }
        private void btnLogin_Click(object sender, EventArgs e)


        {

            string username = txtboxUsername.Text;
            string password = txtboxPassword.Text;

            try
            {

                conn.Open();
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Cannot be Empty", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }


                SqlCommand cmd = new SqlCommand("select id, username, [password], [ROLE].roletype from USERS inner join role on users.userrole = [ROLE].roleid\r\nwhere username = @username and [password] = @password ;\r\n", conn);
                cmd.Parameters.AddWithValue("@username", txtboxUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtboxPassword.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                conn.Close();

                if (dataTable.Rows.Count > 0)

                {
                    string usertype = dataTable.Rows[0]["roletype"].ToString();

                    if (usertype == "admin")
                    {

                        MessageBox.Show("Welcome Admin!", "Logging in as Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                    }

                    else if (usertype == "employee")
                    {

                        MessageBox.Show("Welcome Employee!", "Logging in as Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Employee employee = new Employee();
                        employee.Show();
                        this.Hide();

                    }

                    else if (usertype == "user")
                    {
                        MessageBox.Show("Welcome User", "Logging in as User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        User user = new User();
                        user.Show();
                        this.Hide();
                    }



                    else if (usertype != "admin" || usertype != "employee" || usertype != "user")
                    {
                        MessageBox.Show("Error");
                    }

                    else
                    {
                        throw new InvalidOperationException("Invalid username or password.");
                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }



        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


        void Clear()
        {
            txtboxPassword.Text = "";
            txtboxUsername.Text = "";
              
        }
    }
}
