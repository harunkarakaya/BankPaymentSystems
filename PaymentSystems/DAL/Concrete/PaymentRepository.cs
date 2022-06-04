using DAL.Abstract;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Concrete
{
    public class PaymentRepository : IPaymentRepository
    {
        public Bank GetBankName(int bincode)
        {
            Bank bankobj;

            using (var paymentdbContext = new PaymentDbContext())
            {
                bankobj = paymentdbContext.Banks.Where(x => x.BinCode == bincode).FirstOrDefault();
            }

            return bankobj;
        }

        public int DoPay(Payment p)
        {
            int saveResult = 0;
            using(var paymentdbContext = new PaymentDbContext())
            {
                paymentdbContext.Payments.Add(p);
                saveResult = paymentdbContext.SaveChanges();               
            }

            return saveResult;
        }
    }
}
