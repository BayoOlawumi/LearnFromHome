using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
   
    public class GenericCollections
    {
        /****************************List<T>*******************/
        //The T represents the type
        public List<int> myList = new List<int>();
        public void addMyListExample()
        {
            //Generic Collections handles only items that are type compatible
            // with the type of collection
            //It means you can only add integer values to myList
            myList.Add(34);
            myList.Add(43);
            myList.Add(23);
            myList.Add(53);
        }
        public List<int> getMyListExample()
        {
            return myList;
        }


        /****************************Dictionary<TKey, TValue>*******************/
        //Dictionary has a Key and a value
        //The TKey represents the type of the Key
        //The TValue represents the type of the Value
        public Dictionary<int, string> myDict = new Dictionary<int, string>();
        public void addMyDictionaryExample()
        {
            myDict[2] = "Solape";
            myDict[3] = "Bimpe";
            myDict[4] = "Kolapo";
            myDict.Add(5, "Pauline");
            myDict.Add(6, "Josephine");

        }
        public Dictionary<int,string> getMyDictionaryExample()
        {
            return myDict;
        }
        public bool checkKeyexist(int incomingkey)
        {
            return myDict.ContainsKey(incomingkey);
        }


        /****************************Queue<T>*******************/
        //The T represents the type
        //Works with the principle of First In, First Out
        public Queue<int> myQueue = new Queue<int>();
        public void addMyQueueExample(int val)
        {
            myQueue.Enqueue(val);
        }
        public int remove_and_returnMyQueue()
        {
            return myQueue.Dequeue();
        }
        //To display only you use Peek()

        // Other GenericCollections include 
        // SortedList<Tkey,TValue>
        //  HashSet<T>
        //  LinkedList<T>
    }
}
