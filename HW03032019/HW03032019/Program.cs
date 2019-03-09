using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03032019
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();
            myQueue.Enqueue(new Customer(1, "Moshe", 1982, "Jerusalem", 34, 100));
            myQueue.Enqueue(new Customer(2, "Misha", 1987, "Tel aviv", 37, 48));
            myQueue.Enqueue(new Customer(3, "Masha", 1943, "Jerusalem", 25, 200));
            Console.WriteLine($"The amount of customers in the Q is: {myQueue.Count}.");
            Console.WriteLine("===================================================");

            List<Customer> customersList = new List<Customer>()
            {
                new Customer(1,"Maikl",1989,"Philedelphia",4, 52),
                new Customer(2,"Noumi",1983,"Afrika",23,50),
                new Customer(3,"Makron",1987,"France",1, 100)
            };
            customersList.ForEach(n => Console.WriteLine(n));
            Console.WriteLine("====================================");
            myQueue.Init(customersList);
            Console.WriteLine("The customer list:");
            int MyQueLength = myQueue.Count;
            for (int i = 0; i < MyQueLength; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine("=======================================");
            myQueue.Init(customersList);
            myQueue.SortByBirtYear();
            Console.WriteLine("The customer list SortByBirthYear:");
            MyQueLength = myQueue.Count;
            for (int i = 0; i < MyQueLength; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine("==============================================");
            myQueue.Init(customersList);
            myQueue.SortByProtection();
            Console.WriteLine("The customer list SortByProtection:");
            MyQueLength = myQueue.Count;
            for (int i = 0; i < MyQueLength; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine("====================================================");
            myQueue.Init(customersList);
            myQueue.SortByTotalPurchases();
            Console.WriteLine("The customer list SortByTotalPurchases:");
            MyQueLength = myQueue.Count;
            for (int i = 0; i < MyQueLength; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine("====================================================");
            myQueue.Init(customersList);
            myQueue.Dequeue(2);
            Console.WriteLine("The customer list Dequeue(2):");
            for (int i = 0; i < MyQueLength; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine("===================================================");

            myQueue.Init(customersList);
            Console.WriteLine($"The customer with most protectzia is: {myQueue.DequeueProtectizia()}.");
            Console.WriteLine($"The Next customer is: {myQueue.WhoIsNext()}.");

            Console.ReadLine();
        }
    }
}
