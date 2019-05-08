using SurfaceCalculatorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceCalculatorHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri address = new Uri("http://localhost:8000/SurfaceCalculator/");

            ServiceHost host = new ServiceHost(typeof(CalculatorService), address);
            try
            {
                host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");

                ServiceMetadataBehavior SMB = new ServiceMetadataBehavior();
                SMB.HttpGetEnabled = true;
                host.Description.Behaviors.Add(SMB);

                host.Open();
                Console.WriteLine("Ready!");

                Console.WriteLine("Press <Enter> to terminate the service");
                Console.ReadLine();
                host.Close();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                Console.ReadLine();
                host.Abort();
            }
        }
    }
}
