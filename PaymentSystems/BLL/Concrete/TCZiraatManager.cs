using BLL.Abstract;
using BLL.StateResult;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Concrete
{
    public class TCZiraatManager : BaseBankManager 
    {
        public override ResultStatus Pay(Payment p)
        {
            ResultStatus rs = base.Pay(p);

            return rs;
        }

    }
}
