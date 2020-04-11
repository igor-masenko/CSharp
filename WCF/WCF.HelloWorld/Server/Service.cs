using System;

namespace Server
{
    public class Service : IContractor
    {
        public void WelcomeMessage(string input)
        {
            Console.WriteLine($"The Service received next message: {input}");
        }
    }
}
