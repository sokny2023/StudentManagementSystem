using StudentManagementSystem.Controllers;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Views
{
    public partial class StudentForm : Form
    {

        private StudentController studentController;

        public StudentForm()
        {
            InitializeComponent();
            studentController = new StudentController();
            this.Load += Form1_Load;  // Ensure the Load event is attached
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();  // Automatically load students when the form loads
        }

        private void LoadStudents()
        {
            var students = studentController.GetAllStudents();  // Fetch students from the controller
            //dataGridView1.DataSource = students;  // Set the data source of dataGridView1 to display the students
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs and create a new Student instance
            var student = new Student
            {
                Name = txtName.Text,
                Age = int.TryParse(txtAge.Text, out int age) ? age : 0,
                Email = txtEmail.Text
            };

            studentController.AddStudent(student);
            MessageBox.Show("Student added successfully.");
            LoadStudents();  // Refresh the student list
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadStudents();  // Manually reload students
        }

    }
}
