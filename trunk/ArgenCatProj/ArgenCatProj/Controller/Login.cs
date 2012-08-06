using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArgenCatProj.Model;

namespace ArgenCatProj.Controller
{
    public class Login
    {
        private argencatEntities _db;

        public Login()
        {
            _db = new argencatEntities();
        }

        public bool CheckFields(string userName, string pass)
        {
            userName = userName.Trim();
            pass = pass.Trim();
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(pass))
            {
                return true;
            }
            return false;
        }

        public bool CheckLogin(string userName, string pass)
        {
            userName = userName.Trim();
            pass = pass.Trim();
            IQueryable<user> usr = from users in _db.users
                                   where users.Name == userName && users.Pass == pass
                                   select users;
            return usr.Count() > 0;
        }

        public void UpdateCurrentUser(string userName, string pass)
        {
            userName = userName.Trim();
            pass = pass.Trim();
            user usr = (from users in _db.users
                                   where users.Name == userName && users.Pass == pass
                                   select users).First();
            FMain.CurrentUser = usr;
        }
    }
}
