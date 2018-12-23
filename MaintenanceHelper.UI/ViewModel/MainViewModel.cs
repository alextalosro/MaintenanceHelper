using MaintenanceHelper.Model;
using MaintenanceHelper.UI.Data;
using RobotControllerMaintenance.Alarm;
using System.Collections.ObjectModel;

namespace MaintenanceHelper.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {


        public MainViewModel(INavigationViewModel navigationViewModel)
        {
            NavigationViewModel = navigationViewModel;
        }

        public void Load()
        {
            NavigationViewModel.Load();
        }

        public INavigationViewModel NavigationViewModel { get; }
        

    }
}
