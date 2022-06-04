using BLL.Abstract;
using BLL.Concrete;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.IoC
{
    public class ServiceResolver
    {
        private static WindsorContainer container;

        public static IServiceProvider Load(IServiceCollection services)
        {
            container = new WindsorContainer();

            return WindsorRegistrationHelper.CreateServiceProvider(container, services);
        }
    }
}
