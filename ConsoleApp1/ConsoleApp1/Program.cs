using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string name=Console.ReadLine();
            Console.WriteLine(name);
            //2
            double d = 3.4;
            Console.WriteLine(d);
            string s = "baraah";
            Console.WriteLine(s);   
            char c= 'A';
            Console.WriteLine(c);
            bool b = true;
            Console.WriteLine(b);
            int u = 0;
            Console.WriteLine(u);
            const int  ID= 1;
            Console.WriteLine(ID);
            //3
            string[] cars = { "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            //4
            string first_name = Console.ReadLine();
            string last_name = Console.ReadLine();
            int age = Console.ReadLine().Length;
            Console.WriteLine("first name is:" + first_name);
            Console.WriteLine("last name is:" + last_name);
            Console.WriteLine("age:" + age);
            Console.WriteLine($"{first_name}+{ last_name}+{age}");
            //5
            int[,] numbers = { { 1, 1, 2 }, { 1, 1, 2} };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }
            int[] number = new int[3];
            number[0] = 2; 
            number[1] = 5; 
            number[2] = 8; 

           
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }


            Console.WriteLine("Sum of all elements stored in the array is : " + sum);
        }
    }

}
    

