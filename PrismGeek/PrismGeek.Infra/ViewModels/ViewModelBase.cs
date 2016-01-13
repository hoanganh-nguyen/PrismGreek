using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismGeek.Infra
{
    public abstract class ViewModelBase:BindableBase
    {
        string _viewName;
        public string ViewName
        {
            get { return _viewName; }
            set { SetProperty(ref _viewName, value); }
        }

        public ViewModelBase()
        {
            ViewName = "Base";
        }
    }
}
