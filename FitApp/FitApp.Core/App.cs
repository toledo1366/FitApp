using System;
using FitApp.Core.Contracts.Services;
using FitApp.Core.Services;
using MvvmCross;
using MvvmCross.ViewModels;

namespace FitApp.Core
{
    public class App:MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            Mvx.IoCProvider.RegisterType<IConnectivtyService, ConnectivityService>();
        }
    }
}
