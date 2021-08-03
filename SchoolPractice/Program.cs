using System;

namespace SchoolPractice
{
    class Program
    {

        public static void Main(string[] args)
        {
            string CurrectgradeLevel = Student.GetGradeLevel(30);
            Console.WriteLine(CurrectgradeLevel);
            
        }
    }
}
