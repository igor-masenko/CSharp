using System;
using System.ServiceModel;

namespace Server
{
    class Server
    {
        static void Main()
        {
            Console.Title = "SERVER";

            // указание адреса, где ожидать входящие сообщения
            Uri address = new Uri("http://localhost:4000/IContractor");

            // указание привязки, как обмениваться сообщениями
            BasicHttpBinding binding = new BasicHttpBinding();

            // указание контракта
            Type contract = typeof(IContractor);

            // создание провайдера Хостинга с указанием Сервиса
            ServiceHost host = new ServiceHost(typeof(Service));
            host.AddServiceEndpoint(contract, binding, address);

            Console.WriteLine("Opening host...");
            host.Open();
            Console.WriteLine("Host is opened.");

            Console.WriteLine("The App ready for receiving messages...");

            // даёт задержку, чтобы успеть принять сообщение до закрытия хоста
            Console.ReadKey(); 

            Console.WriteLine("Closing host...");
            host.Close();
            Console.WriteLine("Host is closed");

        }
    }
}
