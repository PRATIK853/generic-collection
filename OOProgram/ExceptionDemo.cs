using System;
using System.Collections.Generic;
using System.Text;

namespace OOProgram
{
    class ExceptionDemo
    {
        static void Main(string[] args)
        {
            //int i = 5, y = 0;

            //int result = i / y;  // divideByZeroException

            //Console.WriteLine(result);



            //int[] arr = { 1, 2, 3, 4 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[4]);  //IndexOutOfRangeException 
            //}


            //argumentoutofRange -

            var numbers = new List<int>();

            numbers.Add(2);
            var index = 1;
            Console.WriteLine("Removing item at index {0}", index);

            numbers.RemoveAt(index);

            Console.ReadKey();

        }
    }
}
