using System.ServiceModel;

namespace Client
{
    [ServiceContract]
    interface IContractor
    {
        [OperationContract]
        void WelcomeMessage(string input);
    }
}
