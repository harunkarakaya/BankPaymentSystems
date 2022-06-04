using BLL.StateResult;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstract
{
    public interface IPaymentProvider
    {
        ResultStatus Pay(Payment p);
    }
}
