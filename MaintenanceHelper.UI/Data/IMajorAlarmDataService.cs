using System.Collections.Generic;
using MaintenanceHelper.Model;

namespace MaintenanceHelper.UI.Data
{
    public interface IMajorAlarmDataService
    {
        IEnumerable<MajorAlarm> GetAll();
    }
}