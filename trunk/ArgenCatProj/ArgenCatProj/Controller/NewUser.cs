using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArgenCatProj.Model;

namespace ArgenCatProj.Controller
{
    public class NewUser
    {
        private argencatEntities _db;

        public NewUser()
        {
            _db = new argencatEntities();
        }

        public bool CheckFields(string name, string pass, string pass2)
        {
            name = name.Trim();
            pass = pass.Trim();
            pass2 = pass2.Trim();
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(pass) && !string.IsNullOrEmpty(pass2))
            {
                return true;
            }
            return false;
        }

        public bool CheckEqualPass(string pass, string pass2)
        {
            pass = pass.Trim();
            pass2 = pass2.Trim();
            if(pass == pass2)
            {
                return true;
            }
            return false;
        }

        public bool SaveUser(string name, string pass)
        {
            name = name.Trim();
            pass = pass.Trim();
            
            user u = new user();
            u.Name = name;
            u.Pass = pass;
            _db.AddTousers(u);
            return _db.SaveChanges() > 0;
        }
    }
}
