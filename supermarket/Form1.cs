using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket
{
    public partial class Form1 : Form
    {
        public static int simulation_time = 7;
        public static int maxlen_quene;
        public static int min_customer ;
        public static int max_customer ;
        public static int cashBoxCount ;
        public static int profit_1000;
        public static double add_customer=0.0;
        public Form1()
        {
            InitializeComponent();
        }
       
        public void Form1_Load(object sender, EventArgs e)
        {
           //int maxlen_quene = Int32.Parse(textBox1.Text);
        }

      

       
        /*public int interval_cust()
        {
            min_customer = Int32.Parse(textBox3.Text);
            max_customer = Int32.Parse(textBox4.Text);
            Random ran = new Random();
            return ran.Next(min_customer, max_customer);
        }*/

        private void start_but_Click(object sender, EventArgs e)
        {
            min_customer = Int32.Parse(textBox3.Text);
            max_customer = Int32.Parse(textBox4.Text);
            cashBoxCount = Int32.Parse(textBox2.Text);
            maxlen_quene= Int32.Parse(textBox1.Text);
            profit_1000 = Int32.Parse(textBox5.Text);
            if (min_customer > max_customer)
            {
                MessageBox.Show("Invalid parameter");
                Application.Restart();
            }
            Random ran = new Random();
            Shop shop = new Shop(cashBoxCount, maxlen_quene, ran);
            working model = new working(shop, min_customer, max_customer, simulation_time);
            model.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            { 
                if((e.KeyChar<'0')||(e.KeyChar>'9'))//这是允许输入0-9数字
                { 
                    e.Handled = true; 
                }
            }

                
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }
    }
}
