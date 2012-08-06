using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArgenCatProj.Model;
using System.Collections;
using System.Data.Objects.SqlClient;

namespace ArgenCatProj.Controller
{
    public class Main
    {
        private argencatEntities _db;

        public Main()
        {
            _db = new argencatEntities();
        }

        public IEnumerable<dynamic> GetAllCurses()
        {
            return GetData(FMain.COURSES, "");
        }

        public IEnumerable<dynamic> GetAllStudents()
        {
            return GetData(FMain.STUDENTS, "");
        }

        public IEnumerable<dynamic> GetData(string type, string filter)
        {
            if (type == FMain.COURSES)
            {
                return from courses in _db.courses
                       where courses.Name.Contains(filter)
                       select new { courses.Id, courses.Name, courses.PaymentsCount };
            }
            if (type == FMain.STUDENTS)
            {
                return from students in _db.students
                       where students.Name.Contains(filter) ||
                       students.Dni.Contains(filter)
                       select new
                       {
                           students.Id,
                           students.Number,
                           students.Name,
                           students.Dni,
                           students.Phone,
                           students.Phone2,
                           students.Address
                       };
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
