using BLL.Abstract;
using BLL.StateResult;
using DAL.Concrete;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Concrete
{
    public class BaseBankManager : IPaymentProvider
    {
        PaymentRepository pr = new PaymentRepository();
        ResultStatus result = new ResultStatus();

        public virtual ResultStatus Pay(Payment p)
        {
            result.ResultCode = pr.DoPay(p);

            if (result.ResultCode == 1)
            {
                result.Result = p.BankName + " bankası için ödeme yapıldı.";

                return result;
            }
            else
            {
                result.Result = p.BankName + " bankası için ödeme yapılamadı.";
            }

            return result;
        }
    }
}
