using SchoolManagement.Data.Models;
using SchoolManagement.Data.ViewModels;

namespace SchoolManagement.Data.Services
{
    public class StudentsService
    {
        private AddDbContext _context;
        public StudentsService(AddDbContext context)
        {
            _context = context;
        }

        public void AddStudent(StudentsVM student)
        {
            var _student = new Models.Student()
            {
                Name = student.Name,
                Address = student.Address,
                Email = student.Email,
                Class = student.Class,
                Marks = student.Marks
            };
            _context.Students.Add(_student);
            _context.SaveChanges();
        }

        public List<Student> GetStudents() =>  _context.Students.ToList();
        public Student GetStudentsById(int Id) => _context.Students.FirstOrDefault(n=>n.Id == Id);

        //public Student GetStudent()
        //{
        //    return Student;
        //}

        public Student UpdateStudentById(int Id, StudentsVM students)
        {
            var _Student = _context.Students.FirstOrDefault(n => n.Id == Id);
            if(_Student != null)
            {
                _Student.Name = students.Name;
                _Student.Address = students.Address;
                _Student.Email = students.Email;
                _Student.Class = students.Class;
                _Student.Marks = students.Marks;

                _context.SaveChanges();
            }
            return _Student;
        }

        public void DeleteStudentById(int Id)
        {
            var _student = _context.Students.FirstOrDefault(n => n.Id == Id);
            if( _student != null)
            {
                _context.Students.Remove(_student);
                _context.SaveChanges();
            }
        }
    }
}
