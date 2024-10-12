using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //1
                Console.WriteLine("Enter Number");
                int sum = 0;
                int num;
                for (int i = 0; i < 10; i++)
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    sum += num;



                }
                Console.WriteLine(sum);
                //2
                Console.WriteLine("enter number");
                int number = Convert.ToInt32(Console.ReadLine());
                int cube = number * number * number;
                Console.WriteLine("cube of the number" + cube);


                //3
                int[] Year = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
                Console.WriteLine("the Year more then 1950 is ");
                int[] result = getYear(Year);
                foreach (int year in result)
                {
                    Console.WriteLine(year);
                }
                //4
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your age in day is {ageInDays(age)}");
                //5
                Console.WriteLine("the number of total leg is " + numberOfLeg(2, 3, 5));
                //6
                int pw = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"the power of number {power(pw)} ");
                //8
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"is the year leap {IsLeapYear(y)}");
                //9
                int p = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"is the number prime {IsPrime(p)}");

            }
        }

        private static object ageInDays(int age)
        {
            throw new NotImplementedException();
        }

        private static string numberOfLeg(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        private static object power(int pw)
        {
            throw new NotImplementedException();
        }

        private static bool IsLeapYear(int y)
        {
            throw new NotImplementedException();
        }

        private static bool IsPrime(int p)
        {
            throw new NotImplementedException();
        }

        private static int[] getYear(int[] year)
        {
            throw new NotImplementedException();
        }
    }
}

