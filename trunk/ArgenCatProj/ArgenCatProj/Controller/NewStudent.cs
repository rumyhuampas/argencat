using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArgenCatProj.Model;

namespace ArgenCatProj.Controller
{
    public class NewStudent
    {
        private argencatEntities _db;

        public NewStudent()
        {
            _db = new argencatEntities();
        }

        public bool CheckFields(string number, string name, string dni, string address, string phone, string phone2)
        {
            number = number.Trim();
            name = name.Trim();
            dni = dni.Trim();
            address = address.Trim();
            phone = phone.Trim();
            phone2 = phone2.Trim();
            if (!string.IsNullOrEmpty(number) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(dni))
            {
                return true;
            }
            return false;
        }

        public bool SaveStudent(string number, string name, string dni, string address, string phone, string phone2)
        {
            number = number.Trim();
            name = name.Trim();
            dni = dni.Trim();
            address = address.Trim();
            phone = phone.Trim();
            phone2 = phone2.Trim();
            
            student s = new student();
            s.Number = Convert.ToInt32(number);
            s.Name = name;
            s.Dni = dni;
            s.Address = address;
            s.Phone = phone;
            s.Phone2 = phone2;
            _db.AddTostudents(s);
            return _db.SaveChanges() > 0;
        }
    }
}
