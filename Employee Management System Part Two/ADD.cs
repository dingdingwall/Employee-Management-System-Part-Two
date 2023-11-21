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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace Employee_Management_System_Part_Two
{
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMS_DATABASEDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.eMS_DATABASEDataSet.EMPLOYEE);

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
           
            // Get the values from the textboxes


            string ID, EmployeeName, Address, Email, Date, Contact;

            ID = txtbox_ID.Text;
            EmployeeName = txtbox_EmployeeName.Text;
            Address = txtbox_Address.Text;
            Email = txtbox_Email.Text;
            Date = txtbox_Date.Text;
            Contact = txtbox_contact.Text;

            // Validate input fields
            if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(EmployeeName) || string.IsNullOrEmpty(Address) ||
                string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Date) || string.IsNullOrEmpty(Contact))
            {
                MessageBox.Show("Please fill in all the fields. None of the fields can be empty.", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method without executing the insert query
            }

            // Create a SqlConnection
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DCPNVH9\\SQLEXPRESS;Initial Catalog=EMS_DATABASE;Integrated Security=True"))
            {

               
                conn.Open();

                // Use parameterized query to avoid SQL injection
                // E call nalang diri ang katong mga strings
                string query = "INSERT INTO EMPLOYEE (ID, EmployeeName, [Address], Email, [Date], Contact) " +
                               "VALUES (@ID, @EmployeeName, @Address, @Email, @Date, @Contact)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@EmployeeName", EmployeeName);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@Contact", Contact);

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {

                        MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.eMPLOYEETableAdapter.Fill(this.eMS_DATABASEDataSet.EMPLOYEE);
                    }
                    else
                    {
                        
                        MessageBox.Show("Failed to add employee.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string ID = txtbox_delete.Text;

            // Create a SqlConnection
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DCPNVH9\\SQLEXPRESS;Initial Catalog=EMS_DATABASE;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    // Use parameterized query to avoid SQL injection
                    string query = "DELETE FROM EMPLOYEE WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter to the query
                        cmd.Parameters.AddWithValue("@ID", ID);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.eMPLOYEETableAdapter.Fill(this.eMS_DATABASEDataSet.EMPLOYEE);
                        }
                        else
                        {
                            MessageBox.Show("No employee found with the given ID.", " Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtbox_ID.Text ="";
           txtbox_EmployeeName.Text ="";
            txtbox_Address.Text = "";
           txtbox_Email.Text = "";
          txtbox_Date.Text = "";
            txtbox_contact.Text = "";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

             Admin admin = new Admin();
            admin.Show();
            this.Hide();


        }
    }
}





