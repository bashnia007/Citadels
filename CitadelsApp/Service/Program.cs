using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(GameService));
            host.Open();
            ServiceHost host2 = new ServiceHost(typeof(DuplexService));
            host2.Open();
            Console.WriteLine("Сервис запущен");
            Console.ReadLine();
            host.Close();
            host2.Close();
        }
    }
}
