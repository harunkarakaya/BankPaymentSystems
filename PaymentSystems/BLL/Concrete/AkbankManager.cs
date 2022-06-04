using BLL.Abstract;
using BLL.StateResult;
using DAL.Concrete;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Concrete
{
    public class AkbankManager : BaseBankManager
    {
        public override ResultStatus Pay(Payment p)
        {
            ResultStatus rs = base.Pay(p);

            return rs;
        }
    }
}
