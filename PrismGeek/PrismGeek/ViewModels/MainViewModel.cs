using Microsoft.Practices.Prism.Commands;
using Prism.Regions;
using PrismGeek.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismGeek.MasterTabControl.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        string _status;
        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }
        DelegateCommand<string> NavigateCommand { get; set; }
        IRegionManager _regionManager;
        public MainViewModel(IRegionManager regionManager)
        {
            Status = "Ready";
            NavigateCommand = new DelegateCommand<string>(Navigate);
            _regionManager = regionManager;
        }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate("ListRegion", uri);
        }
    }
}
