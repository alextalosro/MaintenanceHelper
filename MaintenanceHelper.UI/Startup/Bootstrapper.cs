using Autofac;
using MaintenanceHelper.UI.Data;
using MaintenanceHelper.UI.ViewModel;

namespace MaintenanceHelper.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();

            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            //builder.RegisterType<JobDataService>().As<IJobDataService>();
            builder.RegisterType<NavigationButtonDataService>().As<INavigationButtonDataService>();

            return builder.Build();
        }
    }
}
