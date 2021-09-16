using System;
using FitApp.Core.Contracts.Services;
using Xamarin.Essentials;

namespace FitApp.Core.Services
{
    public class ConnectivityService:IConnectivtyService
    {
        public ConnectivityService()
        {
        }

        public bool CheckIfInternetIsAvailable()
        {
            if(Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
