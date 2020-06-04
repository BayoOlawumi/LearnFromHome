using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates_and_Events
{

    /// <summary>
    /// Manages the Rooms
    /// </summary>
    public class RoomManager
    {
        public void OnCustomerRegistered(object source, CustomerEventArgs e)
        {
            Thread.Sleep(1000);
            Console.WriteLine("\n Room has been assigned to {0}", e.CustomerName);
            
        }
    }

    public class HotelManager
    {
        public void OnRoomAssigned(object source, CustomerEventArgs d)
        {
            Thread.Sleep(2000);
            Console.WriteLine("\n Collect the car keys");
        }
    }
}
