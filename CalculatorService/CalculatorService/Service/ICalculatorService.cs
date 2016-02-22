using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    [ServiceContract]
    public interface ICalculatorService
    {

        [OperationContract(Name="SumInt")]
        int Sum(int a, int b);

        [OperationContract(Name = "SumDouble")]
        double Sum(double a, double b);

        [OperationContract]
        double Subtract(double a, double b);

    }
}
