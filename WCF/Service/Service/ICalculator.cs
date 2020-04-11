using System.ServiceModel;

namespace Microsoft.ServiceModel.Samples
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double arg1, double arg2);

        [OperationContract]
        double Subtract(double minuend, double subtrahend);

        [OperationContract]
        double Multiply(double multiplier, double multiplicand);

        [OperationContract]
        double Devide(double devidend, double divisor);
    }
}
