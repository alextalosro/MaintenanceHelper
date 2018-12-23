using MaintenanceHelper.Model;
using MaintenanceHelper.UI.Data;
using RobotControllerMaintenance.Alarm;
using System.Collections.ObjectModel;

namespace MaintenanceHelper.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase, INavigationViewModel
    {
        private INavigationButtonDataService _navigationButtonDataService;
        private NavigationButton _selectedNavigationButton;

        public NavigationViewModel(INavigationButtonDataService navigationButtonDataService)
        {
            NavigationButtons = new ObservableCollection<NavigationButton>();
            _navigationButtonDataService = navigationButtonDataService;
        }

        public void Load()
        {
            var navigationButtons = _navigationButtonDataService.GetAll();
            NavigationButtons.Clear();

            foreach (var item in navigationButtons)
            {
                NavigationButtons.Add(item);
            }
        }

        public ObservableCollection<NavigationButton> NavigationButtons { get; set; }

        public NavigationButton SelectedNavigationButton
        {
            get { return _selectedNavigationButton; }
            set
            {
                _selectedNavigationButton = value;
                OnPropertyChanged();
            }
        }
    }
}
