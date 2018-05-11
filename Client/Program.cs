using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client {
    class Program {
        static void Main(string[] args) {
            var service = new Repo.RepositoryClient("BasicHttpBinding_IRepository");
            var p = service.GetPoint(2);
            Console.WriteLine($"x = {p.X}; y = {p.Y}");
        }
    }
}
