using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class ArraylistDemo
    {
        static void Main(string[] args)
        {
            //Creating an Arraylist
            ArrayList myList = new ArrayList();

            //Adding elements to ArrayList
            myList.Add("Hello");
            myList.Add("World");
            myList.Add(1);
            myList.Add(3.4);
            myList.Add(6);
            myList.Add(3);


            Console.WriteLine("Count : " + myList.Count);
            Console.WriteLine("Capacity : " + myList.Capacity);

            // To check if the ArrayList has fixed size or not 
            Console.WriteLine(myList.IsFixedSize);

            // To check if the ArrayList is read-only or not 
            Console.WriteLine(myList.IsReadOnly);

            // Displaying the elements
            Console.WriteLine("The initial ArrayList: ");

            foreach (var i in myList)
            {
                Console.WriteLine(i);
            }

            // removing 4 elements starting from index 0
            myList.RemoveRange(0, 4);

            myList.Remove(1); // removing element using actual value

           myList.RemoveAt(2); //renoving element using index.

            // Displaying the modified ArrayList
            Console.WriteLine("The ArrayList after Removing elements: ");

            // Displaying the elements in ArrayList
            foreach (var i in myList)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
