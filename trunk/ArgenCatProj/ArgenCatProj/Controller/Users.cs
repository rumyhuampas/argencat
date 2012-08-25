using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArgenCatProj.Model;

namespace ArgenCatProj.Controller
{
    public class Users
    {
        private argencatEntities _db;

        public Users()
        {
            _db = new argencatEntities();
        }

        public IEnumerable<dynamic> GetUsers()
        {
            return from users in _db.users
                   select users;
        }
    }
}
