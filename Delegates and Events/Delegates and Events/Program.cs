using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates_and_Events
{
    class Program
    {
        //Why do we need events, we want objects/class to communicate without having knowledge of one-another
        //In this case, CustomerManager knows nothing about the Receipt Issuer , it is decoupled.
        //So how do we tell the subcriber even the methods to call

        //CustomerManager---Publisher
        //ReceiptsIssuer---Subscriber
        //RoomManager---Subscriber

        public static string complete_name { get; set; }
        static void Main(string[] args)
        {


            //******************Explanation and Implementation fo Delegate************************//
            //Console.WriteLine("Welcome to our Hotel, please enter your firstname");
            //string firstname = Console.ReadLine();
            //Console.WriteLine("Welcome to our Hotel, please enter your lastname");
            //string lastname = Console.ReadLine();

            ////Delegate a function or method pointer

            //NameManipulator Inst = new NameManipulator();
            ////You can also point to a method using
            //UserDetails Deleg = Inst.ExtractInitials;
            //Console.WriteLine(Deleg(firstname, lastname));
            ////Invoking the method called concertenate
            //Deleg += Inst.ConcatenateName;
            //Console.WriteLine(Deleg(firstname, lastname));

            //*****************End of Delegate Example******************************************//


            //******************Begining of events explanation*************************//

            Console.WriteLine("Welcome to our Hotel, please enter your name");
            string name = Console.ReadLine();
            CustomerManager NewCustomer = new CustomerManager(); //Publisher
            ReceiptsIssuer IssueReceipt = new ReceiptsIssuer(); //Subscriber
            RoomManager AssignRoom = new RoomManager(); //Subscriber
            HotelManager hotelManager = new HotelManager();//Subscriber

            //We need to register the subscriber before calling the method

            NewCustomer.CustomerRegistered += IssueReceipt.OnCustomerRegistered;
            NewCustomer.CustomerRegistered += AssignRoom.OnCustomerRegistered;
            NewCustomer.CustomerRegistered += hotelManager.OnRoomAssigned;
            NewCustomer.RegisterCustomer(name);

            //*******************End of events explanation****************************//

            Console.ReadKey();
        }
    }
   

 
}
