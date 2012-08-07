using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArgenCatProj.Model;

namespace ArgenCatProj.Controller
{
    public class RegisterStudent
    {
        private argencatEntities _db;

        public RegisterStudent()
        {
            _db = new argencatEntities();
        }

        public IEnumerable<dynamic> GetCourses()
        {
            return from courses in _db.courses
                   select courses.Name;
        }

        public bool Register(student stdnt, string course)
        {
            course c = (from courses in _db.courses
                       where courses.Name == course
                       select courses).First();

            paymentplan pp = new paymentplan();
            pp.Name = stdnt.Name + "_" + c.Name;
            for (int i = 1; i <= c.PaymentsCount; i++)
            {
                payment p = new payment();
                p.Number = i;
                p.Payed = 0;

                paymentplan_payments ppp = new paymentplan_payments();
                ppp.payment = p;

                pp.paymentplan_payments.Add(ppp);
            }
            student_course_paymentplan sc = new student_course_paymentplan();
            sc.courseId = c.Id;
            sc.studentId = stdnt.Id;
            pp.student_course_paymentplan.Add(sc);
            
            _db.AddTopaymentplans(pp);
            _db.SaveChanges();
            return true;
        }

        public student GetStudentData(int id)
        {
            return (from students in _db.students
                    where students.Id == id
                    select students).First();
        }
    }
}
