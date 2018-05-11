using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using Service;

namespace ServiceHostApp {
    class Program {
        static void Main(string[] args) {
            using (var service = new ServiceHost(typeof(Repository))) {
                service.Open();
                Console.WriteLine("Service started..");
                Console.ReadKey();
            }
        }
    }
}
