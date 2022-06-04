using ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Abstract
{
    public interface IPaymentRepository
    {
        Bank GetBankName(int bincode);

        int DoPay(Payment p);
    }
}
