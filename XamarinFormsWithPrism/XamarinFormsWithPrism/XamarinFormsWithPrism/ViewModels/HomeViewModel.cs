using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XamarinFormsWithPrism.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        private string _name = "Divikiran Ravela";

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public HomeViewModel()
        {
            
        }
    }
}
