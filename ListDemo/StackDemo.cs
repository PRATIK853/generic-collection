using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            //Creatign stack
            Stack st = new Stack();

            //add element in stack
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);

            foreach (var items in st)
            {
                Console.WriteLine(items);//display element
            }

            st.Pop();

            //after Pop method display
            foreach (var items in st)
            {
                Console.WriteLine(items);//display element
            }

            Console.ReadKey();

        }
    }
}
