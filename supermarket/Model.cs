using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace supermarket
{

    public class Model
    {
        public Random rnd = new Random();
        public Shop shop_m;
        public List<Customer> customers = new List<Customer>();
        int newCustomerTimer; // таймер обратного отсчёта 
                              // до появления очередного покупателя
        public int currentTime = 0;  // текущее время
        public int Simulation_time;
        public static int max_customer, min_customer;

        public Model(Shop shop, int min_cust, int max_cust,int simulation_time)
        {
            double temp=1- Form1.add_customer;
            shop_m = shop;
            if (working.fewer)
            {
                newCustomerTimer = rnd.Next(60, 120);
                //working.label21.Text = "Late night: fewer customers";
            }
            else
            {
                //working.label21.Text = "daytime: normal business hours";
                newCustomerTimer = rnd.Next(Convert.ToInt32(min_cust * temp), Convert.ToInt32(max_cust * temp)); // до нового покупателя
            }
                max_customer = max_cust;
            min_customer = min_cust;
            Simulation_time = simulation_time;
        }


        public void Tick()
        {
            working.time_temp--;
            if (working.time_temp <= 0) working.time_temp = 0;
             currentTime++;
            shop_m.Tick();
            foreach (Customer c in customers)
                c.Tick();
            if (--newCustomerTimer <= 0)
            {
                customers.Add(new Customer(rnd, shop_m));
                newCustomerTimer = rnd.Next(min_customer, max_customer); // до нового покупателя
            }

        }
    }
}
