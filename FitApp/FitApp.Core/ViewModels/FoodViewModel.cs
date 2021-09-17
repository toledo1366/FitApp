using System;
using FitApp.Core.Contracts.DataModels;
using FitApp.Core.Contracts.Services;

namespace FitApp.Core.ViewModels
{
    public class FoodViewModel:ListViewModel<MealDataView>
    {
        public FoodViewModel(IConnectivtyService connectivtyService):base(connectivtyService)
        {
        }
    }
}
