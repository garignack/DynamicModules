﻿using System;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using VTX.Core.Services;

namespace VTX.Core
{
    public class CoreModule : IModule
    {
        private readonly IUnityContainer _container;

        public CoreModule(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException($"{nameof(container)}");
            }

            _container = container;
        }

        public void Initialize()
        {
            _container.RegisterType<ICustomerService, CustomerService>(new ContainerControlledLifetimeManager());
        }
    }
}