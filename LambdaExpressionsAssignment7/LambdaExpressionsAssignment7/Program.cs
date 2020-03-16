using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionsAssignment7
{

    class Program
    {
        class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);
            foreach( var num in evenNumbers)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();

            Console.WriteLine();

            list.RemoveAll(x => x > 3);
            foreach (var num in list)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();

            Console.WriteLine();

            var pets = new Pet[]
            {
                new Pet {Name="Rex", Age=8},
                new Pet {Name="Shark", Age=1},
                new Pet {Name="Boaras", Age=13}
            };

            var sortedPets = pets.OrderBy(pet => pet.Age);
            foreach (Pet pet in sortedPets)
            {
                Console.WriteLine("{0} - {1}", pet.Name, pet.Age);
            }

            Console.WriteLine();

            Console.WriteLine();

            list = new List<int>() { 20, 1, 8, 9, 44 };

            evenNumbers = list.FindAll((i) =>
            {
                Console.WriteLine("value of i is: {0}", i);
                return (i % 2) == 0;
            });

            Console.WriteLine();

            Console.WriteLine("Here are your even numbers: ");
            foreach (int even in evenNumbers)
            {
                Console.WriteLine("{0} ", even);
            }

            Console.WriteLine();
        }
    }
}
