using BLL.Abstract;
using BLL.Concrete;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.IoC
{
    public class ContainerInstall
    {
        private static WindsorContainer container;

        public static IWindsorContainer Install()
        {
            container = new WindsorContainer();

            container.Register(Component.For<IPaymentProvider>().ImplementedBy<GarantiManager>().Named("T.GARANTİ BANKASI A.Ş."));

            container.Register(Component.For<IPaymentProvider>().ImplementedBy<AkbankManager>().Named("AKBANK T.A.Ş."));

            container.Register(Component.For<IPaymentProvider>().ImplementedBy<TCZiraatManager>().Named("T.C.ZİRAAT BANKASI A.Ş."));

            container.Register(Component.For<IPaymentProvider>().ImplementedBy<TurkEkonomiManager>().Named("TÜRK EKONOMİ BANKASI A.Ş."));

            container.Register(Component.For<IPaymentProvider>().ImplementedBy<YapiveKrediManager>().Named("YAPI VE KREDİ BANKASI A.Ş."));

            container.Register(Component.For<IPaymentProvider>().ImplementedBy<QNBFinansManager>().Named("QNB FİNANSBANK A.Ş."));

            container.Register(Component.For<IPaymentProvider>().ImplementedBy<DenizManager>().Named("DENİZBANK A.Ş."));

            return container.Install();
        }
    }
}
