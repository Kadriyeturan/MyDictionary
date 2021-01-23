using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(0, "Kadriye");
            myDictionary.Add(1, "Bora");
            myDictionary.Add(2, "Hasan");
            myDictionary.Add(3, "Canberk");
            myDictionary.Add(4, "Lily");

            foreach (var name in myDictionary.Keys)
            {
                Console.WriteLine(name);
            }
            foreach (var number in myDictionary.Values)
            {
                Console.WriteLine(number);

            }

            Console.ReadLine();
        }
    }
}

