using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            class person {
            public string name;
            int age;
            string city;
            //poperties
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public string City
            {
                get { return city; }
                set { city = value; }
            }

        }
        person per1 = new person();
        per1.name = "baraah" ;
       
        
        
        }
    }
}
