using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket
{
    public enum State { shopping, searching, queued, done, fail };
    public class Customer
    {
        Random rnd;
        double pro=Form1.profit_1000/1000.0;
        Shop shop;  // Связь с магазином
        public double cash;    // сумма покупки
        public State state; // текщее состояние
        public int stateTimer;     // таймер обр.отсчёта до смены состояния
        //int failed = 0;
        public Customer(Random rnd, Shop shop)
        {
            this.rnd = rnd;
            this.shop = shop;
            shop.NewCustomer(this);
            cash = rnd.Next(30, 7000);
            state = State.shopping;
            stateTimer = rnd.Next(5, 30); // на покупки
        }


        
    




        public void Tick()
        {
            if (state == State.queued)
            {
               // Shop.profit += this.cash*0.1;
                return;
            }
            if (--stateTimer <= 0)
            {
                switch (state)
                {
                    case State.shopping:
                        state = State.searching;
                        stateTimer = rnd.Next(5, 10); // на поиск кассы
                        break;
                    case State.searching:
                        CashBox cb = shop.FindCashBox();
                        if (cb == null)
                        {
                            state = State.fail;
                            shop.CustomerLeave(this);
                            working.failed+=1;
                        }
                        else
                        {
                            state = State.queued;
                            cb.Enqueue(this);
                        }
                        break;
                }
            }
        }

        public void ServiceDone()
        {
            Shop.profit += this.cash * (pro-working.dis);
            state = State.done;
            shop.CustomerLeave(this);
            working.successed++;
        }

    }
}
