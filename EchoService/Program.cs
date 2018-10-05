using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EchoService.ServiceReference1;

namespace EchoService
{
    class Program
    {
        static void Main(string[] args)
        {
            //EchoServiceClient ist in WSDL beschrieben 
            EchoServiceClient client = new EchoServiceClient();
            var result = client.Echo("Hello World");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
