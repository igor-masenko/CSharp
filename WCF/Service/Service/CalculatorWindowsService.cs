using System.ServiceModel;
using System.ServiceProcess;

namespace Microsoft.ServiceModel.Samples
{
    public class CalculatorWindowsService : ServiceBase
    {
        public ServiceHost serviceHost = null;
        public CalculatorWindowsService()
        {
            ServiceName = "WCFWidnowsServiceSample";
        }

        public static void Main()
        {
            ServiceBase.Run(new CalculatorWindowsService());
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
                serviceHost.Close();

            serviceHost = new ServiceHost(typeof(CalculatorService));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
