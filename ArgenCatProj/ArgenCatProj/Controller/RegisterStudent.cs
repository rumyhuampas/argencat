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
        private student _student;

        public RegisterStudent(student stdnt)
        {
            _db = new argencatEntities();
            _student = stdnt;
        }

        public IEnumerable<dynamic> GetCourses()
        {
            return from courses in _db.courses
                   select courses.Name;
        }

        public bool Register(string course)
        {
            course c = (from courses in _db.courses
                       where courses.Name == course
                       select courses).First();

            paymentplan pp = new paymentplan();
            //_db.AddTopaymentplans(pp);
            //_db.SaveChanges();
            for (int i = 0; i < c.PaymentsCount; i++)
            {
                payment p = new payment();
                p.Number = i;
                p.Payed = 0;

                paymentplan_payments ppp = new paymentplan_payments();
                ppp.payment = p;

                pp.paymentplan_payments.Add(ppp);

                //_db.AddTopaymentplan_payments(ppp);
            }
            student_courses sc = new student_courses();
            sc.courseId = c.Id;
            //sc.paymentPlanId = pp.Id;
            //_db.AddTostudent_courses(sc);
            pp.student_courses.Add(sc);
            _db.AddTopaymentplans(pp);
            return _db.SaveChanges() > 0;
        }
    }
}
