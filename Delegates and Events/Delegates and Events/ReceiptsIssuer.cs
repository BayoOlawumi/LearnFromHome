using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates_and_Events
{


    /// <summary>
    /// Manages the Receipts for the Hotel
    /// </summary>
    class ReceiptsIssuer
    {
        public void OnCustomerRegistered(object source, CustomerEventArgs e)
        {
            Thread.Sleep(1000);
            Console.WriteLine("\n Receipt has been issued to {0}", e.CustomerName);
            
        }
    }

}
