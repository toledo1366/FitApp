using System;
using System.Collections.Generic;
using FitApp.Core.Contracts.Services;
using MvvmCross.ViewModels;

namespace FitApp.Core.ViewModels
{
    public class BaseViewModel:MvxViewModel
    {
        readonly IConnectivtyService _connectivtyService;

        public BaseViewModel(IConnectivtyService connectivtyService)
        {
            _connectivtyService = connectivtyService;
        }

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }

        private int _dayCount;
        public int DayCount
        {
            get => _dayCount;
            set
            {
                _dayCount = value;
                RaisePropertyChanged(() => DayCount);
            }
        }

        private bool _isInternetAvailable;
        public bool IsInternetAvailable
        {
            get => _isInternetAvailable;
            set
            {
                _isInternetAvailable = value;
                RaisePropertyChanged(() => IsInternetAvailable);

                _connectivtyService.CheckIfInternetIsAvailable();
            }
        }
    }
}
