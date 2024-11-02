using StudentManagementSystem.Models;
using StudentManagementSystem.Services;

namespace StudentManagementSystem.Controllers
{
    public class StudentController
    {
        private readonly StudentService _studentService;

        // constructor
        public StudentController()
        {
            _studentService = new StudentService();
        }

        // display students
        public List<Student> GetAllStudents()
        {
            return _studentService.GetAllStudents();
        }

        // add student
        public void AddStudent(Student student)
        {
            _studentService.AddStudent(student);
        }
    }
}
