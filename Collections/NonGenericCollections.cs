using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class NonGenericCollections
    {
        /****************************ArrayList*******************/
        public ArrayList myArrList = new ArrayList();
        public void addMyArrayList()
        {

            myArrList.Add("Pelumi");
            myArrList.Add(43);
            myArrList.Add(2.890);
        }
        public ArrayList getMyListExample()
        {
            return myArrList;
        }


        /****************************Stack*******************/
        //First In,Last Out
        //The Pop remove and return the top value
        //The Push represents the type of the Value
        public Stack myStack = new Stack();
        public void addMyStack()
        {
            myStack.Push("Solape");
            myStack.Push(34);
            myStack.Push(3.5);

        }
        public Stack getMyStack()
        {
            return myStack;
        }
        public object RemoveVal()
        {
            return myStack.Pop();
        }


        /****************************Hashtable*******************/
        //Collection of Key and Value that are organized based on the hashcode of the key
        public Hashtable myHashtable = new Hashtable();

        /* Hashtable htbl = new Hashtable(){

                                {"msg", "Welcome"},
                                {"site", "Tutlane"},
                                 {1, 20.5},
                                {2, null}
                            };
                            */
        public void addMyHashtable(string keyz, string val)
        {
            //myHashtable.Add("msg", "Welcome");
            //myHashtable.Add("site", "Tutor");
            //myHashtable[3] = "Tutorials"
            //myHashtable.Add(2, null);
            myHashtable.Add(keyz, val);
        }
        public void removeMyHashtable(string keyz)
        {
            // Removing hashtable elements with keys
            myHashtable.Remove(keyz);
        }
    }
}
