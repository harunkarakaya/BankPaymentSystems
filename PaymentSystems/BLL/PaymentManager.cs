using BLL.StateResult;
using DAL.Concrete;
using ENTITIES;
using System;

namespace BLL
{
    public class PaymentManager
    {
        PaymentRepository pr = new PaymentRepository();

        public ResultStatus GetBankName(int? bincode)
        {
            ResultStatus rslt = new ResultStatus();
            Bank bankobj;

            if (bincode != null || bincode != 0)
            {               
                bankobj = pr.GetBankName(bincode.Value);

                if (bankobj != null)
                {
                    if (bankobj.BankName != "")
                    {
                        rslt.Result = bankobj.BankName;

                        if (bankobj.IsActive == true)
                        {
                            rslt.ResultCode = 1; //success
                        }
                        else
                        {
                            rslt.ResultCode = 0;
                            rslt.Result = "Banka kartı aktif değildir. Lütfen kartınızı aktif duruma getiriniz.";
                        }

                        return rslt;
                    }                                     
                }
                else 
                {
                    rslt.Result = "Böyle bir banka kartı bulunamamaktadır.";
                    rslt.ResultCode = 0;
                    return rslt;
                }
                
            }

            rslt.Result = "Girdiğiniz banka kartı numarasını kontrol ediniz.";
            rslt.ResultCode = 0;
            return rslt;     
        }

        public ResultStatus PaymentControl(Payment p)
        {
            ResultStatus rslt = new ResultStatus();

            if (p.Owner == "" || p.CCV == "" || p.CreditCardHolder == "" || p.Amount == 0 || p.CreditCardNumber < 100000)
            {
                rslt.Result = "Girmiş olduğunuz bilgiler eksik. Lütfen istenilen bilgileri giriniz.";
                rslt.ResultCode = 0;

                return rslt;
            }
            else
            {
                rslt.Result = "Başarılı";
                rslt.ResultCode = 1;

                return rslt;
            }

        }

    }
}
