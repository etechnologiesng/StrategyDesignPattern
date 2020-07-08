using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            var orderconfirmed = new OrderConfirmed();
            orderconfirmed.CustomerTransport(new BusTransport());
            
        }
    }
}
