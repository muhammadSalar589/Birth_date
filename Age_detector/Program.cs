using System;

namespace Age_detector
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            int age;
            int year;

            for(int i=0; i < 10; i++)
            {
                Console.Write("Enter Your Name: ");
                name = Console.In.ReadLine();
                Console.WriteLine("-------------------------------");

                Console.Write("Enter Your age: ");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------");

                DateTime dateDate = DateTime.Today;
 
                int result = dateDate.Year;
                Console.WriteLine($"Now is {dateDate} So Your Birth date is:  {mwalid(age,result)} ");

            }
        }

        static int mwalid(int age, int year)
        {
            int mwalid;

            mwalid = year - age;
            return mwalid;
        }
    }
}
