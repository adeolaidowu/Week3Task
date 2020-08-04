using System;
using System.Collections;
using System.Collections.Generic;

namespace Week3Task
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<string> myList = new MyLinkedList<string>();
            Console.WriteLine(myList.Add("Diagon Alley"));
            Console.WriteLine(myList.Add("Flourish and Blotts"));
            Console.WriteLine(myList.Add("The Leaky Cauldron"));
            Console.WriteLine(myList.Check("Diagon"));
            Console.WriteLine(myList.Add("Chamber of Secrets"));
            Console.WriteLine(myList.IndexOf("Chamber of Secrets"));
            Console.WriteLine(myList.Insert(1,"Salazar Slytherin"));
            Console.WriteLine(myList.IndexOf("Salazar Slytherin")  + " slytherin");
            Console.WriteLine(myList.IndexOf("Flourish and Blotts") + " flourish");
            Console.WriteLine(myList.Insert(0, "Prisoner of Azkaban"));
            Console.WriteLine(myList.IndexOf("Prisoner of Azkaban"));
            Console.WriteLine(myList.IndexOf("Diagon Alley"));
            myList.Print();
            Console.WriteLine();
            myList.Remove(4);
            myList.Print();
            Console.WriteLine(myList.IndexOf("Flourish and Blotts"));
            Console.WriteLine(myList.IndexOf("Chamber of Secrets"));
            //Console.WriteLine(myList.IndexOf("Salazar Slytherin"));
        }

       
    }
}
