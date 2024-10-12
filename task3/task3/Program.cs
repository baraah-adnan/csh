using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //1
            Console.WriteLine("enter first numder:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter last numder:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2)
            {
                Console.WriteLine("the smaller number is" + num1);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("the smaller number is " + num2);
                Console.ReadLine();
            }
            //2
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("the sign is -");

            }
            else
            {
                Console.WriteLine("the sign is +");

            }
            //3
            int[] sort = { 1, 5, 10 };
            Array.Sort(sort);
            foreach (int i in sort)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
        //4



    }
}
