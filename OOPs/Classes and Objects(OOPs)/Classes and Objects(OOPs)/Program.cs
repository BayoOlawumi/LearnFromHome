using System;

namespace Classes_and_Objects_OOPs_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*************Creating Object****************/

            /***********First Object or Instance**************/
            Human Person1 = new Human();

            //Person1.Name = "Kolapo";
            //Console.WriteLine("{0} has {1} of eyes {2", Person1.Name, Person1.eyeNo);
            //Person1.eat();

            ///***********Second Object or Instance**************/
            Human Person2 = new Human("Seyi");
            //Person2.eyeNo = 2;
            //Person2.nose = 1;
            //Console.WriteLine("{0} has {1} of eyes", Person2.Name, Person1.eyeNo);

            //Human Person3 = new Human();
            //Person3.eyeNo = 4;
            //Person3.nose = 3;

            /************Static Example*************************/
            //Console.WriteLine(StaticExamples)


            /************An Instance of Student*******/
            Student std1 = new Student();
            std1.Name = "Timilehin";
            std1.matricNo = "EEE/16/3442";
            std1.level = 500;
            Console.WriteLine(std1.department);
            std1.department = "EEE";
            std1.CGPA = 4.76;
            std1.eat();
            Console.WriteLine("{0} of matric Number: {1} is of the class : {2}", std1.Name, std1.matricNo, std1.classOfDegree());


            /************An Instance of Student*******/
            Student std2 = new Student();
            std2.Name = "Goodness";
            std2.matricNo = "AKG/15/3442";
            std2.level = 400;
            std2.department = "CSC";
            std2.CGPA = 4.46;
            Console.WriteLine("{0} of matric Number: {1} is of the class : {2}", std2.name, std2.matricNo, std2.classOfDegree());
            Console.ReadKey();
        }
    }
}
