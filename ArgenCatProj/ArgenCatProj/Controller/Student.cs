using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArgenCatProj.Model;
using System.Collections;

namespace ArgenCatProj.Controller
{
    public class Student
    {
        private argencatEntities _db;

        public Student()
        {
            _db = new argencatEntities();
        }

        public IEnumerable<dynamic> GetCoursePayments(student stdnt, string CurseName)
        {
            student_course_paymentplan currentStudentCurse = stdnt.student_course_paymentplan.Where(model => model.course.Name == CurseName).First();
            return from planpayments in _db.paymentplan_payments
                   join payments in _db.payments on planpayments.paymentId equals payments.Id
                   where planpayments.paymentplanId == currentStudentCurse.paymentPlanId
                   select new { payments.Id, payments.Payed, payments.Number, payments.RecipNumber, payments.Amount, payments.DatePayed };
        }

        public student GetStudentData(int id)
        {
            return (from students in _db.students
                     where students.Id == id
                     select students).First();
        }

        public payment GetPaymentData(int id)
        {
            return (from payments in _db.payments
                    where payments.Id == id
                    select payments).First();
        }
    }
}
