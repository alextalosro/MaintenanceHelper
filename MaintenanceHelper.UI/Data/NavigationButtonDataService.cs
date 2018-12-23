using MaintenanceHelper.Model;
using System.Collections.Generic;

namespace MaintenanceHelper.UI.Data
{
    class NavigationButtonDataService : INavigationButtonDataService
    {
        public IEnumerable<NavigationButton> GetAll()
        {
            yield return new NavigationButton
            {
                ButtonName = "Alarms"
            };
            yield return new NavigationButton
            {
                ButtonName = "Job"
            };
        }
    }
}
