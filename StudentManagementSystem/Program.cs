using MySql.Data.MySqlClient;
using StudentManagementSystem.Utils;
using StudentManagementSystem.Views;

namespace StudentManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // test database connection
            //TestDatabaseConnection();

            ApplicationConfiguration.Initialize();
            Application.Run(new StudentForm());
        }

        static void TestDatabaseConnection()
        {
            try
            {
                // Attempt to create and open a connection
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Connection to MySQL server successful!", "Connection Test");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Connection Test Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Connection Test Error");
            }
        }
    }
}