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
        private student _student;

        public Student(student stdnt)
        {
            _db = new argencatEntities();
            _student = stdnt;
        }

        public IQueryable<payment> GetCursePayments(string CurseName)
        {
            student_courses currentStudentCurse = _student.student_courses.Where(model=>model.course.Name == CurseName).First();
            return from planpayments in _db.paymentplan_payments
                    join payments in _db.payments on planpayments.PaymentId equals payments.Id
                    where planpayments.PaymentPlanId == currentStudentCurse.paymentPlanId
                    select payments;
        }
    }
}
