using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProvider
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ServiceHost(typeof(Service));
            service.Open();

            Console.WriteLine($"Press any key to close the service..");
            Console.ReadKey();
        }
    }
}
