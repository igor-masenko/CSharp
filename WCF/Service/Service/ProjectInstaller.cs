using System.ComponentModel;
using System.ServiceProcess;
using System.Configuration.Install;

namespace Microsoft.ServiceModel.Samples
{
    [RunInstaller(true)]
    public class ProjectInstaller : Installer
    {
        private readonly ServiceProcessInstaller process;
        private readonly ServiceInstaller service;
       
        public ProjectInstaller()
        {
            process = new ServiceProcessInstaller
            {
                Account = ServiceAccount.LocalSystem
            };

            service = new ServiceInstaller
            {
                ServiceName = "WCFWindowsServiceSample"
            };

            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
