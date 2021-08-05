using System;

namespace SchoolPractice
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Student Tiah = new Student("Tiah", 1, 1, 4.0);
            string CurrectgradeLevel = Student.GetGradeLevel(30);
            Console.WriteLine(CurrectgradeLevel);
            
        }
        
    }
}
