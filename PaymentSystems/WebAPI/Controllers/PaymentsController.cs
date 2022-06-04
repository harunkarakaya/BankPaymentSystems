using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.Abstract;
using ENTITIES;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IoC;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        /// <summary>
        /// Payment with credit card
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [EnableCors("*")]
        [HttpPost]
        public string Payment([FromBody] Payment p)
        {
            PaymentManager pm = new PaymentManager();
            var paymentcontrol = pm.PaymentControl(p);

            if (paymentcontrol.ResultCode == 0)
            {
                return paymentcontrol.Result;
            }
            else
            {
                var bankName = pm.GetBankName(p.CreditCardNumber);

                if (bankName.ResultCode == 1)
                {
                    p.BankName = bankName.Result;
                    var container = ContainerInstall.Install(); //create bank containers //                   
                    var conresult = container.Resolve<IPaymentProvider>(bankName.Result).Pay(p);

                    return conresult.Result;
                }
                else
                {
                    return bankName.Result;
                }
            }
                   
        }
    }
}