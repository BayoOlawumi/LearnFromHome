using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates_and_Events
{
    public class CustomerEventArgs : EventArgs
    {
        public string CustomerName { get; set; }
    }
    
    class CustomerManager
    {


        //The delegates defines the nature of the eventHandler/methods in the subscribers that will be called
        //1. Define a delegate
        //2. Define an event
        //3. Raise an Event

        /// <summary>
        /// </summary>
        /// <param name="source">The class that is publishing the event</param>
        /// <param name="args">Any additional data we want to send with the event</param>
        public delegate void RegisterCustomerEventHandler(object source, CustomerEventArgs args);

        /// <summary>
        /// The event is fired when the customer must have been added
        /// </summary>
        public event RegisterCustomerEventHandler CustomerRegistered;


        /// <summary>
        /// I can write my event like this, with this I will not have to create a delegate
        /// </summary>
        
        // public event EventHandler<CustomerEventArgs> CustomerRegistered;

        //How does the OnCustomerRegistered notify the subscribers?
        public void RegisterCustomer(string name)
        {
            Thread.Sleep(1000);
            Console.WriteLine("{0} was successfully enrolled", name);
            //The method below is event publisher method which raises the event
            //This method will notify the subscribers
            OnCustomerRegistered(name);

        }

        /// <summary>
        /// This event will notify all the subscribers
        /// </summary>
        protected virtual void OnCustomerRegistered(string name)
        {
            //This will check if there is any subscriber
            if (CustomerRegistered != null)
            {
                //The source is the class and we are returning nothing
                CustomerEventArgs dt = new CustomerEventArgs();
                dt.CustomerName = name;
                CustomerRegistered(this,dt);
            }
        }

    }
}
