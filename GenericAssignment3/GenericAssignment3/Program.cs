using System;
using System.Collections.Generic;

namespace GenericAssignment3
{

    public class MyGenericClass<T>
    {
        public List<T> myType = new List<T>();

        public void AddToList(T type)
        {
            myType.Add(type);
        }

        public T GetNumber(int i)
        {
            return myType[i]; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var numList = new MyGenericClass<int>();
            numList.AddToList(1);
            numList.AddToList(10);
            numList.AddToList(100);
            numList.AddToList(1000);
            numList.AddToList(10000);

            var f = numList.GetNumber(0);
            var g = numList.GetNumber(3);

            var result = f + g;

            Console.WriteLine("Result of adding 1 and 1000 : {0}", result);
            Console.WriteLine(numList.GetNumber(4));

            var stringList = new MyGenericClass<string>();
            stringList.AddToList("For a Complete List");
            stringList.AddToList(" of Sayings");
            stringList.AddToList("Please Refer To");
            stringList.AddToList("The Owners Guide");
            stringList.AddToList("Nancy");
            stringList.AddToList("Mike");
            stringList.AddToList("Bob");

            Console.WriteLine(stringList.GetNumber(4));

            Console.WriteLine(stringList.GetNumber(0));
            

            Console.ReadLine();


        }
    }
}
