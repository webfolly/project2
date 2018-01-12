using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_demo.Models
{
    public class DataStore
    {
        private static DataStore _instance;
        public static DataStore Instance()
        {
            if (_instance == null)
            {
                _instance = new DataStore();
            }
            return _instance;
        }
        private List<Student> _Students;
        private List<Course> _Courses;
        private List<Lecture> _Lectures;

        private static List<Student> InitStudents()
        {
            List<Student> Seed = new List<Student>();
            Seed.Add(new Student
            {
                Id = 1,
                Name = "Jordan",
                Age = 18
            });
            Seed.Add(new Student
            {
                Id = 2,
                Name = "Mary",
                Age = 19
            });

            return Seed;
        }
        private static List<Course> InitCourses()
        {
            List<Course> Seed = new List<Course>();
            Seed.Add(new Course
            {
                CourseId = 1,
                Name = "C# programming"
            });
            Seed.Add(new Course
            {
                CourseId = 2,
                Name = "Agile Development Metholody"
            });

            return Seed;
        }
        private static List<Lecture> InitLectures()
        {
            List<Lecture> Seed = new List<Lecture>();
            Seed.Add(new Lecture
            {
                LectureId = 1,
                LectureName = "current climate and opportunities"
            });
            Seed.Add(new Lecture
            {
                LectureId = 2,
                LectureName = "Threat Analysis and Defense Technologies"
            });
            return Seed;
        }
        public DataStore()
        {
            _Students = InitStudents();
            _Courses = InitCourses();
            _Lectures = InitLectures();
        }
        public List<Student> GetAllStudents()
        {
            return _Students;
        }
        public List<Course> GetAllCourses()
        {
            return _Courses;
        }
        public List<Lecture> GetAllLectures()
        {
            return _Lectures;
        }
        public Student GetStudentById(int Id)
        {
            Student result = _Students.FirstOrDefault((Student arg) => arg.Id == Id);
            return result;
        }
        public Course GetCourseById(int Id)
        {
            Course result = _Courses.FirstOrDefault((Course arg) => arg.CourseId == Id);
            return result;
        }
        public Lecture GetLectureById(int Id)
        {
            Lecture result = _Lectures.FirstOrDefault((Lecture arg) => arg.LectureId == Id);
            return result;
        }
        public void AddStudent(Student newStudent)
        {
            _Students.Add(newStudent);
        }
        public void AddCourse(Course newCourse)
        {
            _Courses.Add(newCourse);
        }
        public void AddLecture(Lecture newLecture)
        {
            _Lectures.Add(newLecture);
        }
        public Student UpdateStudent(Student newStudent)
        {
            Student result = _Students.FirstOrDefault((Student arg) => arg.Id == newStudent.Id);
            if (result != null)
            {
                result.Name = newStudent.Name;
                result.Age = newStudent.Age;
                result.Gender = newStudent.Gender;
                result.Nationality = newStudent.Nationality;
                result.StudentFee = newStudent.StudentFee;
                result.CreditLmtd = result.CreditLmtd;
            }
            return result;

        }
        public Course UpdateCourse(Course newCourse)
        {
            Course result = _Courses.FirstOrDefault((Course arg) => arg.CourseId == newCourse.CourseId);
            if (result != null)
            {
                result.Name = newCourse.Name;
                result.Description = newCourse.Description;
                result.MaxNum = newCourse.MaxNum;
                result.Credit = newCourse.Credit;

            }
            return result;

        }
        public Lecture UpdateLecture(Lecture newLecture)
        {
            Lecture result = _Lectures.FirstOrDefault((Lecture arg) => arg.LectureId == newLecture.LectureId);
            if (result != null)
            {
                result.LectureName = newLecture.LectureName;
                result.Payroll = newLecture.Payroll;
                result.MsgFromStudent = newLecture.MsgFromStudent;
            }
            return result;
        }
        public bool DeleteStudent(int Id)
        {
            bool result = false;
            Student obj = _Students.FirstOrDefault((Student arg) => arg.Id == Id);
            if (obj != null)
            {
                _Students.Remove(obj);
                result = true;
            }
            return result;
        }
        public bool DeleteCourse(int Id)
        {
            bool result = false;
            Course obj = _Courses.FirstOrDefault((Course arg) => arg.CourseId == Id);
            if (obj != null)
            {
                _Courses.Remove(obj);
                result = true;
            }
            return result;
        }
        public bool DeleteLecture(int Id)
        {
            bool result = false;
            Lecture obj = _Lectures.FirstOrDefault((Lecture arg) => arg.LectureId == Id);
            if (obj != null)
            {
                _Lectures.Remove(obj);
                result = true;
            }
            return result;
        }





    }
}
