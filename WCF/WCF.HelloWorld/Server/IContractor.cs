using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    public interface IContractor
    {
        [OperationContract]
        void WelcomeMessage(string input);
    }
}
