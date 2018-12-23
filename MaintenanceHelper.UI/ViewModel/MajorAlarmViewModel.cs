using MaintenanceHelper.Model;
using MaintenanceHelper.UI.Data;
using RobotControllerMaintenance.Alarm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceHelper.UI.ViewModel
{
    class MajorAlarmViewModel : ViewModelBase, IMajorAlarmDataService
    {
        private IMajorAlarmDataService _majorAlarmDataService;
        private MajorAlarm _selectedMajorAlarm;

        public MajorAlarmViewModel(IMajorAlarmDataService majorAlarmDataService)
        {
            MajorAlarms = new ObservableCollection<MajorAlarm>();
            _majorAlarmDataService = majorAlarmDataService;
        }

        public void Load()
        {
            var majorAlarm = _majorAlarmDataService.GetAll();
            MajorAlarms.Clear();

            foreach (var item in majorAlarm)
            {
                MajorAlarms.Add(item);
            }
        }

        public IEnumerable<MajorAlarm> GetAll()
        {
            return _majorAlarmDataService.GetAll();
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
