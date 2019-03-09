using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03032019
{
    class MyQueue
    {
        List<Customer> customers;

        public MyQueue()
        {
            customers = new List<Customer>();
        }

        public void Enqueue(Customer c)
        {
            customers.Add(c);
        }
        public Customer Dequeue ()
        {
            if (customers.Count == 0)
                return null;
            Customer FirstLine = customers[0];
            customers.RemoveAt(0);
            return FirstLine;
        }
        public void Init(List<Customer> customers)
        {
            this.customers.Clear();
        }
        public void Clear()
        {
            this.customers.Clear();
        }
        public Customer WhoIsNext()
        {
            if (customers.Count == 0)
                return null;
            return customers[0];
        }
        public int Count
        {
            get
            {
                return customers.Count;
            }
        }
        public void SortByProtection()
        {
            customers.Sort(new CustomerCompareByProtection());
        }
        public void SortByTotalPurchases()
        {
            customers.Sort(new CustomerCompareByTotalPurchases());

        }
        public void SortByBirtYear()
        {
            customers.Sort();
        }
        public List<Customer> Dequeue(int number)
        {
            if(number > customers.Count)
            {
                Console.WriteLine("queuqe is shorter than dequeue");
            }

            if(customers.Count == 0)
            {
                return new List<Customer>();
            }

            List<Customer> result = new List<Customer>();
            while(customers.Count > 0 && result.Count < number)
            {
                result.Add(customers[0]);
                customers.RemoveAt(0);
            }

            return result;
        }
        public void AniRakSheeala(Customer c)
        {
            customers.Insert(0, c);
        }
        public Customer DequeueProtectizia()
        {
            if (customers.Count == 0)
                return null;

            int maxProtectzia = customers[0].Protection;
            int index = 0;

            for (int i = 1; i < customers.Count; i++)
            {
                Customer c = customers[i];
                if(c.Protection > maxProtectzia)
                {
                    maxProtectzia = c.Protection;
                    index = i;
                }
            }
            Customer result = customers[index];
            customers.RemoveAt(index);
            return result;
        }
    }
}
