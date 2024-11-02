using MySql.Data.MySqlClient;
using StudentManagementSystem.Models;
using StudentManagementSystem.Utils;

namespace StudentManagementSystem.Services
{
    public class StudentService
    {
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Students", connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Age = Convert.ToInt32(reader["Age"]),
                        Email = reader["Email"].ToString()
                    });
                }
            }
            return students;
        }

        public void AddStudent(Student student)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Students (Name, Age, Email) VALUES (@Name, @Age, @Email)", connection);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.ExecuteNonQuery();
            }
        }
    }
}


