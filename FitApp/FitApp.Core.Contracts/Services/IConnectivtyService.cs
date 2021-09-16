using System;
namespace FitApp.Core.Contracts.Services
{
    public interface IConnectivtyService
    {
        bool CheckIfInternetIsAvailable();
    }
}
