using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class OrderConfirmed
    {

        public void CustomerTransport(ITransportStrategy transport)
        {

            //Now the customer can now travel with the desired means
            //at run time
            transport.TransportCustomers();
        }
    }
}
