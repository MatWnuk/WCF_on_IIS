namespace SurfaceCalculatorLib
{
    public class CalculatorService : ICalculator
    {
        public double Square(double a)
        {
            double result = a * a;
            return result;
        }
        public double Rectangle(double a, double b)
        {
            double result = a * b;
            return result;
        }
        public double Triangle(double a, double h)
        {
            double result = (a * h) / 2;
            return result;
        }
        public double Circle(double a)
        {
            double pi = 3.14;
            double result = pi * (a * a);
            return result;
        }
        public double Trapeze(double a, double b, double h)
        {
            double result = ((a + b) * h) / 2;
            return result;
        }
    }
}