using SurfaceCalculatorClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceCalculatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient client = new CalculatorClient();
            Console.WriteLine("Ready!");
            try
            {
                double a = double.Parse(Console.ReadLine());
                double result = client.Square(a);
                Console.WriteLine("Square surface is equal: {0}", result);

                a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                result = client.Rectangle(a, b);
                Console.WriteLine("Rectangle surface is equal: {0}", result);

                a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                result = client.Triangle(a, h);
                Console.WriteLine("Triangle surface is equal: {0}", result);

                a = double.Parse(Console.ReadLine());
                result = client.Circle(a);
                Console.WriteLine("Circle surface is equal: {0}", result);

                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                h = double.Parse(Console.ReadLine());
                result = client.Trapeze(a, b, h);
                Console.WriteLine("Trapeze surface is equal: {0}", result);

                Console.WriteLine("Click <Enter> to close this windows!");
                Console.ReadLine();
                client.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
                client.Close();
            }
        }
    }
}
