using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArgenCatProj.Model;

namespace ArgenCatProj.Controller
{
    public class Main
    {
        private argencatEntities _db;
        private IEnumerable<dynamic> _courses;
        private IEnumerable<dynamic> _students;

        public Main()
        {
            _db = new argencatEntities();
            _courses = from courses in _db.courses
                        select new {courses.Id, courses.Name} ;
            _students = (from students in _db.students
                         select new { students.Id, students.Number, students.Name, students.Dni, 
                             students.Phone, students.Phone2, students.Address }).OrderBy(model => model.Name);
        }

        public IEnumerable<dynamic> GetAllCurses()
        {
            return _courses;
        }

        public IEnumerable<dynamic> GetAllStudents()
        {
            return _students;
        }

        public IEnumerable<dynamic> FilterList(string type, string filter)
        {
            if (type == FMain.COURSES)
            {
                return _courses.Where(model => model.Name.Contains(filter));
            }
            if (type == FMain.STUDENTS)
            {
                return _students.Where(model => model.Name.Contains(filter));
            }
            return null;
        }

        public student GetStudent(int id)
        {
            return (from students in _db.students
                    where students.Id == id
                    select students).First();
        }
    }
}
