using System;
using System.Collections.Generic;
using FitApp.Core.Contracts.Services;
using MvvmCross.Commands;

namespace FitApp.Core.ViewModels
{
    public class ListViewModel<T>:BaseViewModel
    {
        public ListViewModel(IConnectivtyService connectivtyService):base(connectivtyService)
        {
            
        }

        private List<T> _items;
        public List<T> Items
        {
            get => _items;
            set
            {
                _items = value;
                RaisePropertyChanged(() => Items);
            }
        }

        private void AddItem(T item)
        {
            Items.Add(item);
        }
    }
}
