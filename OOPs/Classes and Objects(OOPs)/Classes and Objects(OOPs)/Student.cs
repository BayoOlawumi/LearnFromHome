using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Objects_OOPs_
{
    class Student: Human
    {
        
        public string matricNo;
        private double cgpa;
        public string department
        {
            get;set;
        }

        public int level;

        public double CGPA
        {
            get{
                return cgpa;
            }
            set{
                if (value > 5.0)
                {
                    cgpa = 0.00;
                }
                else
                {
                    cgpa = value;
                }
            }
        }
        public string classOfDegree()
        {
            this.speechRate = 34;
            if(cgpa<=5.0 && cgpa>=4.5)
            {
                return "First Class";

            }
            else if(cgpa<=4.49 && cgpa>=4.00)
            {
                return "Second Class Upper";
            }
            else if(cgpa<=3.99 && cgpa>=3.5)
            {
                return " Second Class Lower";
            }
            else if (cgpa<=3.49 && cgpa >=2.5)
            {
                return " Third Class";
            }
            else{
                return "Pass";
            }
        }
        public string storeDetail()
        {
            Console.WriteLine("Information has been succesfully stored");
            return "Success";
        }
    }
}
