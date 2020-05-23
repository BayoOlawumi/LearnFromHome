using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Objects_OOPs_
{
    public static class StaticExamples
    {
       
        public static int currentVal = 4;

        public static int nextValue()
        {
            currentVal++;
            return currentVal;
        }
    }
}
