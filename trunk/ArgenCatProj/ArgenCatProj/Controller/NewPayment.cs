using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArgenCatProj.Model;

namespace ArgenCatProj.Controller
{
    public class NewPayment
    {
        private argencatEntities _db;

        public NewPayment()
        {
            _db = new argencatEntities();
        }

        public bool CheckFields(decimal recipNumber, string amount)
        {
            amount = amount.Trim();
            if (recipNumber != 0 && !string.IsNullOrEmpty(amount))
            {
                return true;
            }
            return false;
        }

        public bool SavePayment(int paymentId, decimal recipNumber, string amount)
        {
            amount = amount.Trim();
            payment pmnt = (from payments in _db.payments
                            where payments.Id == paymentId
                            select payments).First();
            pmnt.Payed = 1;
            pmnt.RecipNumber = (int)recipNumber;
            pmnt.Amount = Convert.ToInt32(amount);
            pmnt.DatePayed = DateTime.Now;
            return _db.SaveChanges() > 0;
        }
    }
}
