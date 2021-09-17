using System;
using System.Collections.Generic;

namespace FitApp.Core.Contracts.DataModels
{
    public class MealDataView:BaseDataModel
    {
        public DateTime Date { get; set; }
        public List<Product> Products { get; set; }
    }
}
