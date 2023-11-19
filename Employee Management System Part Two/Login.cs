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

namespace Employee_Management_System_Part_Two
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DCPNVH9\\SQLEXPRESS;Initial Catalog=EMS_DATABASE;Integrated Security=True");
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();

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

                    MessageBox.Show("Welcome Admin!");
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }

                else if (usertype == "employee")
                {
                    MessageBox.Show("Welcome Employee");
                }

                else if (usertype == "user")
                {
                    MessageBox.Show("Welcome User!");
                }

                else
                {
                    return;
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
