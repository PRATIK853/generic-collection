using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class QueueDemo
    {

        static void Main(string[] args)
        {
            Queue mydata = new Queue();

            mydata.Enqueue("1");
            mydata.Enqueue("7");
            mydata.Enqueue("3");
            mydata.Enqueue("4");
            mydata.Enqueue("5");
            mydata.Enqueue("6");


            foreach (var items in mydata)
            {
                Console.WriteLine(items);
            }

            mydata.Dequeue();

            foreach (var items in mydata)
            {
                Console.WriteLine(items);
            }

            Console.ReadKey();



        }
        



    }
}
