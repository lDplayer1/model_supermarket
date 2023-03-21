using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket
{
    public class Shop
    {
        //public static int cashBox_Count;
        public Random rnd = new Random();
        public  List<CashBox> cashboxes = new List<CashBox>();
        public List<Customer> customers = new List<Customer>();
        public int maxQueueLen;
        public static double profit = -1500* Form1.cashBoxCount*7;
        public Shop(int cashBoxCount, int maxQueueLen, Random rnd/*int min_cust,int max_cust*/)
        {
            for (int i = 0; i < cashBoxCount; i++)
                cashboxes.Add(new CashBox(rnd));
            //cashBox_Count = cashBoxCount;
            this.maxQueueLen = maxQueueLen;
        }
        public void NewCustomer(Customer c) // Добавляет покупателя в список магазина
        {
            customers.Add(c);
            c.state = State.shopping;
            c.stateTimer = rnd.Next(5, 31);
        }

        public CashBox FindCashBox() 
        {
            int max = Form1.maxlen_quene;//最长队列 
            CashBox chosen_cb=null;
            
            foreach (CashBox cb in cashboxes)
            {
                //if (cb.QueueLen() < Form1.maxlen_quene)
                //{
                    if (cb.QueueLen() < max)
                    {
                        chosen_cb = cb;
                        max = cb.QueueLen();
                    }
                    
               // }

            }
            return chosen_cb;

                
        }

        public double Profit()
        {
            return Shop.profit;
        }
        
        public void CustomerLeave(Customer c)
        {
            customers.Remove(c);

        }
        public void Tick()
        {
            // customers меняется, foreach нельзя использовать
            for (int i = customers.Count - 1; i >= 0; i--)
                customers[i].Tick();
            foreach (CashBox cb in cashboxes)
                cb.Tick();
        }

    }
}
