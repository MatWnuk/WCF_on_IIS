using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SurfaceCalculatorLib
{
    [ServiceContract(Namespace = "http://localhost:8000")]
    public interface ICalculator
    {
        [OperationContract]
        double Square(double a);
        [OperationContract]
        double Rectangle(double a, double b);
        [OperationContract]
        double Triangle(double a, double h);
        [OperationContract]
        double Circle(double r);
        [OperationContract]
        double Trapeze(double a, double b, double h);
    }
}
