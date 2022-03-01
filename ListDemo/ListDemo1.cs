using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class ListDemo1
    {
        static void Main(string[] args)
        {

            //1.List<T> -- Generic type
           
            //Create a list of method
            List<int> firstlist = new List<int>();

            //adding element in firstlist
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);


            //Removing the element
            firstlist.RemoveAt(3);

            foreach (int items in firstlist)
            {
                Console.WriteLine(items);
            }

            Console.ReadKey();
        }
    }
}
