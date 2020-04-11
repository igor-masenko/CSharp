using System;
using System.ServiceModel;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.Title = "CLIENT";

            // указание, где ожидать входящие сообщения
            Uri address = new Uri("http://localhost:8000/IContractor");
            // указание как обмениваться сообщениями
            BasicHttpBinding binding = new BasicHttpBinding();

            EndpointAddress endpoint = new EndpointAddress(address);

            // то же самое что и Contractor
            ChannelFactory<IContractor> factory = new ChannelFactory<IContractor>(binding, endpoint);
            IContractor channel = factory.CreateChannel();

            Console.WriteLine("Attention! I'm sending message...");
            channel.WelcomeMessage("Hello World!!!");
            Console.WriteLine("The message was sent.");

        }
    }
}
