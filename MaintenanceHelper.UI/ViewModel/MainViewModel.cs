using MaintenanceHelper.Model;
using MaintenanceHelper.UI.Data;
using RobotControllerMaintenance.Alarm;
using System.Collections.ObjectModel;

namespace MaintenanceHelper.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IMajorAlarmDataService _majorAlarmDataService;
        private MajorAlarm _selectedMajorAlarm;

        public MainViewModel(IMajorAlarmDataService majorAlarmDataService)
        {
            MajorAlarms = new ObservableCollection<MajorAlarm>();
            _majorAlarmDataService = majorAlarmDataService;
        }

        public void Load()
        {
            var majorAlarm = _majorAlarmDataService.GetAll();
            MajorAlarms.Clear();

            foreach(var item in majorAlarm)
            {
                MajorAlarms.Add(item);
            }
        }

        public ObservableCollection<MajorAlarm> MajorAlarms { get; set; }

        public MajorAlarm SelectedMajorAlarm
        {
            get { return _selectedMajorAlarm; }
            set
            {
                _selectedMajorAlarm = value;
                OnPropertyChanged();
            }
        }

    }
}
