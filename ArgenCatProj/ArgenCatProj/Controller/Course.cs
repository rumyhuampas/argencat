using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArgenCatProj.Model;

namespace ArgenCatProj.Controller
{
    public class Course
    {
        private argencatEntities _db;

        public Course()
        {
            _db = new argencatEntities();
        }

        public IEnumerable<dynamic> GetCourseStudents(course crs)
        {
            return from csp in _db.student_course_paymentplan
                   join students in _db.students on csp.studentId equals students.Id
                   join ppp in _db.paymentplan_payments on csp.paymentPlanId equals ppp.paymentplanId
                   join p in _db.payments on ppp.paymentId equals p.Id
                   where csp.courseId == crs.Id &&
                   p.Payed == 1
                   select new { students.Number, students.Name };
        }

        public course GetCourseData(int id)
        {
            return (from courses in _db.courses
                     where courses.Id == id
                     select courses).First();
        }
    }
}
