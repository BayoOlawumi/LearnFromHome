using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Objects_OOPs_
{

    class Human
    {
        /***********Constructor*********/
        public Human()
        {
            Console.WriteLine("Welcome to Human");
        }
      
        //This is a Field
        private string name;
        public int age;

        //This is a property
        public string Name
        {
            get
            {
                return name ;
            }
            set
            {
                name = value;
            }
        }

        //public string Name { get => name; set => name = value; }


    
       
    }

}
