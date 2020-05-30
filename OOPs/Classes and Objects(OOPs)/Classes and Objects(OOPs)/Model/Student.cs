using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Objects_OOPs_
{
    class Student : Human
    {
        public Student() : base()
        {
            
        }
        public string matricNo;
        private double cgpa;
        public string department
        {
            get; set;
        }

        public int level;

        public double CGPA
        {
            get
            {
                return cgpa;
            }
            set
            {
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
       
    }
}
