using MaintenanceHelper.Model;
using System.Collections;
using System.Collections.Generic;

namespace MaintenanceHelper.UI.Data
{
    public interface INavigationButtonDataService
    {
        IEnumerable<NavigationButton> GetAll();
    }
}