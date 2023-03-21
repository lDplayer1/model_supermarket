using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket
{
    public class CashBox
    {
        public Random rnd;
        public Queue<Customer> queue = new Queue<Customer>();
        public int serviceTimer = 0; // обратный отсчёт обслуживания

        public CashBox(Random rnd)
        {
            this.rnd = rnd;
        }

        public void Tick()
        {
            if (serviceTimer == 0 && queue.Count > 0)
                serviceTimer = rnd.Next(5, 15); // на обслуживание
            else
            if (serviceTimer > 0)
            {
                serviceTimer--;
                if (serviceTimer == 0)
                {
                    Customer c = queue.Dequeue();
                    c.ServiceDone();
                }
            }
        }

        // Поставить покупателя в очередь
        public void Enqueue(Customer c)
        {
            queue.Enqueue(c);
        }

       /* public void Dequeue(Customer c)
        {
            queue.Dequeue(c);
        }*/
        public int QueueLen()
        {
            return queue.Count;
        }

    }
}
