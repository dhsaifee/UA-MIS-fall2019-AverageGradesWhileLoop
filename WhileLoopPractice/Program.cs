using System;

namespace WhileLoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int count = 0;

            double grade = GetGrade();
            
            while(grade > -1)
            {
                UpdateTotalAndCount(ref total, ref count, grade);
                grade = GetGrade();
            }

            double average = CalculateAverage(total, count);
            DisplayAverage(average);

            Console.ReadKey();

        }


        static double GetGrade()
        {
            Console.Write("Enter grade (-1 to exit): ");
            double grade = double.Parse(Console.ReadLine());
            return grade;
        }


        static void UpdateTotalAndCount(ref double total, ref int count, double grade)
        {
            total = total + grade;
            count++;            
        }


        static double CalculateAverage(double total, int count)
        {
            return total / count;
        }

        static void DisplayAverage(double average)
        {
            Console.WriteLine("The average is " + average);
        }
    }
}
