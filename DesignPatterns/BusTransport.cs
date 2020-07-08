using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class BusTransport : ITransportStrategy
    {
        
     
        
        public void TransportCustomers( )
        {

            //...You can implement the methos to calculate price , or time it will take
            //This depends on the scenerio 
            string strategy = "Bus";
            Console.WriteLine($"The method used here is the {strategy} strategy to transport custusmers to Abuja");
        }
    }
}
