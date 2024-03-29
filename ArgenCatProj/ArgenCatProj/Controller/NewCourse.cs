﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArgenCatProj.Model;

namespace ArgenCatProj.Controller
{
    public class NewCourse
    {
        private argencatEntities _db;

        public NewCourse()
        {
            _db = new argencatEntities();
        }

        public bool CheckFields(string name, decimal pcount)
        {
            name = name.Trim();
            if (!string.IsNullOrEmpty(name))
            {
                return true;
            }
            return false;
        }

        public bool SaveCourse(string name, decimal pcount)
        {
            name = name.Trim();
            course c = new course();
            c.Name = name;
            c.PaymentsCount = (int)pcount;
            _db.AddTocourses(c);
            return _db.SaveChanges() > 0;
        }
    }
}
