using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAssignment4
{
    class Program
    {
        public static IEnumerable<string> GetList()
        {
            List<string> list = new List<string>();
            list.Add("Eggs");  
            list.Add("Milk");
            list.Add("Juice");
            list.Add("Crackers");
            list.Add("Sunflower Seeds");

            foreach (var element in list)
            {
                yield return element;   
            }
        }

        static void Main(string[] args)
        { 
            IEnumerable<string> elements = GetList();
            foreach (var element in elements)  
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
