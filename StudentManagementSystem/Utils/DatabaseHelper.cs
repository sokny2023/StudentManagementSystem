using MySql.Data.MySqlClient;

namespace StudentManagementSystem.Utils
{
    public class DatabaseHelper
    {
        // Connection details for DigitalOcean MySQL
        private static readonly string server = "my-sql-do-user-16845246-0.i.db.ondigitalocean.com";
        private static readonly string port = "25060";
        private static readonly string database = "defaultdb";
        private static readonly string uid = "doadmin";
        private static readonly string password = "AVNS_mfURulE4pKYT47hU_YD"; // Update with your actual password
        private static readonly string sslMode = "Required";

        // Construct the connection string
        private static readonly string connectionString = $"Server={server};Port={port};Database={database};Uid={uid};Pwd={password};SslMode={sslMode};";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
