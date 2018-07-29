using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your name & AGE");
            string name=Console.ReadLine();
            int age = Console.Read();
            Console.WriteLine(name+age);
            Console.ReadKey();
        }
    }
}
