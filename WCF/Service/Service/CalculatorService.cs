namespace Microsoft.ServiceModel.Samples
{
    public class CalculatorService : ICalculator
    {
        public double Add(double term1, double term2) { return term1 + term2; }
        public double Subtract(double minuend, double subtrahend) { return minuend - subtrahend; }
        public double Multiply(double multiplier, double multiplicand) { return multiplier * multiplicand; }
        public double Devide(double devidend, double divisor) { return devidend / divisor; }
    }
}
