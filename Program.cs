using System;

namespace JaggedArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numEmployees = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of working days for each employee: ");
            int numDays = Convert.ToInt32(Console.ReadLine());

            int[][] salaryArray = new int[numEmployees][];

            for (int i = 0; i < numEmployees; i++)
            {
                salaryArray[i] = new int[numDays];

                for (int j = 0; j < numDays; j++)
                {
                    Console.Write($"Enter the salary for day {j + 1} of Employee {i + 1}: ");
                    salaryArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nSalary Details:");
            Console.Write("Day  ");
            for (int i = 0; i < numDays; i++)
            {
                Console.Write($"Day{i + 1} ");
            }
            Console.WriteLine("TotalSalary");

            for (int i = 0; i < numEmployees; i++)
            {
                int weeklySalary = 0;

                Console.Write($"Emp{i + 1}: ");
                for (int j = 0; j < numDays; j++)
                {
                    Console.Write($"{salaryArray[i][j],-5}");
                    weeklySalary += salaryArray[i][j];
                }

                Console.WriteLine($"   {weeklySalary}");
            }

            Console.ReadLine();
        }
    }
}