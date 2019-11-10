using System;
using System.Collections.Generic;

namespace Lava4_Var9
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOne = new List { "one", "two", "three" };
            var listTwo = new List { "fore", "five" };
            var result = listOne + listTwo;           
            foreach(var m in listOne)
            {
                Console.WriteLine(m);
            }

            Console.ReadKey();
        }                         
    }
}
