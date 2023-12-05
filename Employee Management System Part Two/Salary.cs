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
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace Employee_Management_System_Part_Two
{
    public partial class Salary : Form
    {


        public Salary()
        {

            InitializeComponent();

           
        }
        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = IDTextBox.Text;
            string salaryText = SalaryTextBox.Text;
            string dateText = DateTextBox.Text; 

            // Validate input fields
            if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(salaryText) || string.IsNullOrEmpty(dateText))
            {
                MessageBox.Show("Please fill in all the fields. None of the fields can be empty.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate and parse SalaryAmount
            if (!decimal.TryParse(salaryText, out decimal salary))
            {
                MessageBox.Show("Invalid Salary amount. Please enter a valid decimal number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate and parse PaymentDate
            if (!DateTime.TryParse(dateText, out DateTime paymentDate))
            {
                MessageBox.Show("Invalid Payment date. Please enter a valid date.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the given employeeID exists in the EMPLOYEE table
            if (EmployeeExists(ID))
            {
                // If the EmployeeID exists, proceed with the insertion into Salary
                InsertSalary(ID, salary, paymentDate);
            }
            else
            {
                MessageBox.Show("EmployeeID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        bool EmployeeExists(string employeeID)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DCPNVH9\\SQLEXPRESS;Initial Catalog=EMS_DATABASE;Integrated Security=True"))
            {
                connection.Open();

                string checkEmployeeQuery = "SELECT COUNT(*) FROM EMPLOYEE WHERE ID = @EmployeeID";

                using (SqlCommand checkEmployeeCommand = new SqlCommand(checkEmployeeQuery, connection))
                {
                    checkEmployeeCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                    int employeeCount = (int)checkEmployeeCommand.ExecuteScalar();

                    return employeeCount > 0;
                }
            }

        }
        private void InsertSalary(string employeeID, decimal salary, DateTime date)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DCPNVH9\\SQLEXPRESS;Initial Catalog=EMS_DATABASE;Integrated Security=True"))
            {
                connection.Open();

                // Use parameterized query to avoid SQL injection
                string insertSalaryQuery = "INSERT INTO Salary (EmployeeID, SalaryAmount, PaymentDate) VALUES (@EmployeeID, @Salary, @Date)";

                using (SqlCommand insertSalaryCommand = new SqlCommand(insertSalaryQuery, connection))
                {
                    insertSalaryCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                    insertSalaryCommand.Parameters.AddWithValue("@Salary", salary);
                    insertSalaryCommand.Parameters.AddWithValue("@Date", date);

                    // Execute the query
                    int rowsAffected = insertSalaryCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Salary record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert salary record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = "";
            DateTextBox.Text = "";
            SalaryTextBox.Text = "";
        }

        private void pictureboxBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
