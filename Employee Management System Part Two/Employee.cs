using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Employee_Management_System_Part_Two
{
   

    public partial class Employee : Form
    {
        private string connectionString = "Data Source=DESKTOP-DCPNVH9\\SQLEXPRESS;Initial Catalog=EMS_DATABASE;Integrated Security=True";

        public Employee()
        {
            InitializeComponent();


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string employeeID = textBoxView.Text.Trim();

            if (string.IsNullOrEmpty(employeeID))
            {
                MessageBox.Show("Please enter Employee ID");
                return;
            }

            LoadSalaryData(employeeID);
        }

        private void LoadSalaryData(string employeeID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Write your SQL query to fetch salary and payment date information based on employee ID
                    string query = "SELECT SalaryAmount, PaymentDate FROM Salary " +
                                   "WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Read data from the query result
                            decimal salaryAmount = Convert.ToDecimal(reader["SalaryAmount"]);
                            DateTime paymentDate = Convert.ToDateTime(reader["PaymentDate"]);

                            // Display the data in the TextBox
                            lblSalary.Text = $"Salary Amount: {salaryAmount:C}, Payment Date: {paymentDate:yyyy-MM-dd}";
                        }
                        else
                        {
                            MessageBox.Show("Employee ID not found");
                           
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
            
 
           