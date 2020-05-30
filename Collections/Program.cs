using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericCollections myGeneric = new GenericCollections();
            myGeneric.addMyDictionaryExample();
            //foreach (var item in myGeneric.myDict)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}
            if(myGeneric.myDict.ContainsKey(3))
            {
                Console.WriteLine("This dictionary contains 3");
                Console.WriteLine(myGeneric.myDict[3]);
            }
            Console.ReadKey();
          
            
        }
    }
}
